using System;
using System.Collections.Generic;
using Framework.Core;
using Framework;
using Framework.BuildSQLText;
using Framework.Common;
using HursingManage.DBModel;
using Framework.Common.CommonFunction;
using Framework.Entitys;
using System.Data;
using Framework.Common.Helpers;

namespace HursingManage.AL
{
    class DBOracle : DBContext
    {
        //static string connStr = "Data Source=CommodityManage.db";
        public DBOracle(string connStr)
            : base(EmDatabaseType.Oracle, connStr)
        { }
        public DBOracle(string connStr, Func<string> GetOperatorIdHandle, Func<string> GetOperatorNameHandle)
            : this(connStr)
        {
            this.GetOperatorIdHandle = GetOperatorIdHandle;
            this.GetOperatorNameHandle = GetOperatorNameHandle;
        }
        Func<string> GetOperatorIdHandle;
        Func<string> GetOperatorNameHandle;
        static string HostName;
        static string HostIP;

        public override ISqlBuilder CreateSqlBuilder()
        {
            return base.CreateSqlBuilder("ocl_");
        }

        static DBOracle()
        {
            HostName = Utils.GetHostName();
            HostIP = Utils.GetHostIP();
        }

        public DateTime GetNowTime()
        {
            var sql = CreateSqlBuilder();
            sql.AddSQLText("select sysdate from dual");
            var result = QueryWhereScalar(sql);
            return result.ToObject<DateTime>();
        }

        public override IExecResult ExecSql(ISqlBuilder sqlBuilder)
        {
            if (ALBase.LastRunTime > DateTime.Now || DateTime.Now < ALCommon.MinTime)
            {
                LogHelper.LogObj.FatalFormat("当前计算机时间不正确,当前时间:{0},系统登录时间:{1}", DateTime.Now, ALBase.LastRunTime);
                throw new Exception("当前检测到系统时间异常,软件继续运行将会给账目带来混乱!");
            }
            return base.ExecSql(sqlBuilder);
        }
        public override IExecResult Insert<TEntity>(TEntity entity)
        {
            Dictionary<string, object> pValues = new Dictionary<string, object>();
            pValues["PC"] = HostName;
            //pValues["ADDTIME"] = GetNowTime(); //数据库中设计已赋值
            //pValues["LASTTIME"] = GetNowTime();//数据库中设计已赋值
            pValues["OPERATORID"] = GetOperatorIdHandle();
            pValues["OPERATOR"] = GetOperatorNameHandle();
            ReflectionHelper.SetPropertyValue(entity, pValues);
            return base.Insert<TEntity>(entity);
        }
        public override IExecResult Update<TEntity>(TEntity entity)
        {
            Dictionary<string, object> pValues = new Dictionary<string, object>();
            pValues["LASTTIME"] = GetNowTime();
            ReflectionHelper.SetPropertyValue(entity, pValues);
            return base.Update<TEntity>(entity);
        }
    }

    public class ALBase
    {
        static string GetConnectString()
        {
            string connStr;
            if (AppConfig.AppSettings.ConnStringEncrypt)
            {
                try
                {
                    string str = Configurations.GetConnectString("main");
                    string str2 = DEncrypt.Decrypt(str);
                    //host;serviceName;port;uid;pwd;
                    //192.168.2.200;orcl;1521;HLGL;HLGL;
                    string[] str3 = str2.Split(';');
                    connStr = string.Format("User ID={0};Password={1};Data Source=(DESCRIPTION = (ADDRESS_LIST= (ADDRESS = (PROTOCOL = TCP)(HOST = {2})(PORT = {3}))) (CONNECT_DATA = (SERVICE_NAME = {4})))",
                        str3[3], str3[4], str3[0], str3[2], str3[1]);
                }
                catch (Exception ex)
                {
                    LogHelper.LogObj.Error("获取加密连接字符串发生异常", ex);
                    throw ex;
                }
            }
            else
            {
                connStr = Configurations.GetConnectString("main");
            }
            return connStr;
        }

        protected static readonly string ConnectString;

        static ALBase()
        {
            if (string.IsNullOrEmpty(ConnectString))
            {
                //ConnectString = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "CommodityManage.db";
                //ConnectString = Configurations.GetConnectString("main");
                ConnectString = GetConnectString();
            }
        }

        public ALBase()
        {
            _DB = new DBOracle(ConnectString, GetOperatorId,GetOperatorName);
        }
        DBOracle _DB;
        public IDBContext DB { get { return _DB; } }

        /// <summary>
        /// 本系统支持的最小时间,如果当前日期小于该日期则不允许使用,
        /// 这个值原本是为了判断 00-00-01 的默认时间
        /// </summary>
        public static readonly DateTime MinTime = Convert.ToDateTime("2017-03-08");

        static DateTime _LastRunTime;
        public static DateTime LastRunTime { get { return _LastRunTime; } }

        public T_USER_INFO CurrentLoginUser
        {
            get
            {
                return ALLogin.CurrentLoginUser;
            }
        }

        public string GetOperatorId()
        {
            if (CurrentLoginUser != null)
            {
                return CurrentLoginUser.ID;
            }
            return null;
        }
        public string GetOperatorName()
        {
            if (CurrentLoginUser == null) return "SYS";
            return CurrentLoginUser.USER_NAME;
        }

        /// <summary>
        /// 操作员是否为护理部登录
        /// </summary>
        public bool IsHuLiBuLogin
        {
            get { return CurrentLoginUser.USER_TYPE == "护理部"; }

        }
        /// <summary>
        /// 是否管理员登录
        /// </summary>
        public bool IsAdminLogin
        {
            get
            {
                return CurrentLoginUser.USER_TYPE == "管理员";
            }
        }
        /// <summary>
        /// 是否为护士长登录
        /// </summary>
        public bool IsHuShiZhangLogin
        {
            get
            {
                return !IsAdminLogin && !IsHuLiBuLogin;
            }
        }
        /// <summary>
        /// 当前登录科室Id
        /// </summary>
        public string KeShiId
        {
            get
            {
                return CurrentLoginUser.KESHIID;
            }
        }
        /// <summary>
        /// 当前登录科室
        /// </summary>
        public string KeShi
        {
            get
            {
                return CurrentLoginUser.KESHIMINGCHENG;
            }
        }
        
        public ISqlBuilder CreateSqlBuilder(string paramKey)
        {
            return DB.CreateSqlBuilder(paramKey);
        }

        ISqlBuilder _ADSqlBuilder;
        /// <summary>
        /// 高级搜索用的sqlBuilder
        /// </summary>
        public ISqlBuilder ADSqlBuilder
        {
            get
            {
                if (_ADSqlBuilder == null)
                {
                    _ADSqlBuilder = CreateSqlBuilder("ad_");
                }
                return _ADSqlBuilder;
            }
        }
        /// <summary>
        /// 查询高级搜索
        /// </summary>
        public virtual DataTable GetADSearchData<TModel>() where TModel : EntityBase, new()
        {
            var r = DB.QueryWhere<TModel>(ADSqlBuilder);
            return r.ToDataTable();
        }
        /// <summary>
        /// 创建一个新的guid
        /// </summary>
        public string GetGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
        /// <summary>
        /// 获取服务器时间
        /// </summary>
        public DateTime GetNowTime()
        {
            return _DB.GetNowTime();
            //return DateTime.Now;
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        public int ExecSQL(string sql)
        {
            try
            {
                ISqlBuilder sqlBuilder = DB.CreateSqlBuilder();
                var exec = DB.ExecSql(sqlBuilder);
                return exec.Count;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("执行sql文时出错!sql文: " + sql, ex);
                return 0;
            }
        }
        /// <summary>
        /// 数据库日志
        /// </summary>
        public bool WriteDBLog(string logContent, params object[] formatArgs)
        {
            try
            {
                T_LOGS log = new T_LOGS();
                log.LOGCONTENT = formatArgs.Length > 0 ? string.Format(logContent, formatArgs) : logContent;
                log.OPERATORID = CurrentLoginUser==null ? "System":CurrentLoginUser.ID;
                log.OPERATORNAME = CurrentLoginUser == null ? "System" : CurrentLoginUser.USER_NAME;

                DB.Insert<T_LOGS>(log);
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("写数据库日志出错!", ex);
                return false;
            }
        }
        /// <summary>
        /// 获取自定义编号
        /// </summary>
        public string GetBNo(int configId)
        {
            return BNoHelper.GetBNoStr(DB, configId);
        }
    }
}