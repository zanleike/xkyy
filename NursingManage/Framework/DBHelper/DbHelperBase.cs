/*
    创建日期: 2013.6.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2015.1.4    修改并发时共用一个对象操作数据库引发的连接关闭bug,加锁处理
        2015.1.23   所有公共方法该为虚方法,允许子类去重写实现(为其它非标准ado访问用)
        2016.8.30   当执行数据库异常时,OnDbExceptionHandle 处理
        2016.4.26   引入Oracle.ManageddataAccess 后Dispose再次使用（open）会引发异常
 * 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Framework.DBHelper
{
    public abstract class DbHelperBase : IDbHelper
    {
        /// <summary>
        /// 直接获得连接字符串
        /// </summary>
        /// <param name="connStr"></param>
        public DbHelperBase(string connStr)
        {
            _ConnStr = connStr;
            _LockExecNonQuery = new object();
            _LockGetDataReader = new object();
            _LockGetScalar = new object();
            _LockGetDataSet = new object();
        }
        /// <summary>
        /// 连接字符串
        /// </summary>
        protected string _ConnStr;
        /// <summary>
        /// 是否事务
        /// </summary>
        bool _IsTrans = false;

        object _LockExecNonQuery;
        object _LockGetDataReader;
        object _LockGetScalar;
        object _LockGetDataSet;

        protected abstract DbConnection DBConnectionObj { get; }
        protected abstract DbCommand DbCommandObj { get; }
        protected abstract DbDataAdapter DbDataAdapterObj { get; }
        protected DbTransaction DbTransObj;

        public event Action<Exception, string> OnDbExceptionHandle;

        /// <summary>
        /// 当前连接
        /// </summary>
        public DbConnection CurrentConnection
        {
            get
            {
                return DBConnectionObj;
            }
        }
        /// <summary>
        /// 执行sql问错误写日志方法
        /// </summary>
        protected virtual void WriteErrLog(Exception ex, string sqlText, params DbParameter[] param)
        {
            if (OnDbExceptionHandle != null)
            {
                StringBuilder logs = new StringBuilder();
                logs.AppendLine("Sql text:");
                logs.AppendLine(sqlText);
                logs.AppendLine("sql parameter info:");
                if (param != null)
                {
                    foreach (DbParameter item in param)
                    {
                        logs.AppendFormat("parameter name:{0},parameter value:{1}", item.ParameterName, item.Value).AppendLine();
                    }
                }
                OnDbExceptionHandle(ex, logs.ToString());
            }
        }
        /// <summary>
        /// 打开连接,如果已经打开则什么都不执行了
        /// </summary>
        protected virtual void OpenConnection()
        {
            if (DBConnectionObj.State != ConnectionState.Open)
            {
                DBConnectionObj.ConnectionString = _ConnStr;
                DBConnectionObj.Open();
            }
        }
        /// <summary>
        /// 关闭连接,如果没有开始事务或连接打开时才关闭
        /// </summary>
        void CloseConnect()
        {
            if (!_IsTrans)
            {
                if (DBConnectionObj.State == ConnectionState.Open)
                {
                    DBConnectionObj.Close();
                    //DBConnectionObj.Dispose();  2017.4.26 引入Oracle.ManageddataAccess 后Dispose再次使用（open）会引发异常
                }
            }
        }
        /// <summary>
        /// 给当前DbCommand对象赋值,并且OpenConnection();
        /// </summary>
        void SetCommandAndOpenConnect(string sqlText, CommandType cmdType, params DbParameter[] param)
        {
            //按说赋值Connection,CommandType,是不用多次赋值的
            DbCommandObj.CommandType = cmdType;
            DbCommandObj.Connection = DBConnectionObj;
            DbCommandObj.Parameters.Clear();
            if (param != null)
            {
                DbCommandObj.Parameters.AddRange(param);
            }
            DbCommandObj.CommandText = sqlText;
            OpenConnection();
        }

        public DbParameter[] ConvertDbParameter(Dictionary<string, object> paramObj)
        {
            if (paramObj == null) return null;
            List<DbParameter> paramList = new List<DbParameter>();
            foreach (var paramName in paramObj.Keys)
            {
                var dbParam = CreateDbParameter(paramName, paramObj[paramName]);
                paramList.Add(dbParam);
            }
            return paramList.ToArray();
        }

        public abstract DbParameter CreateDbParameter(string paramName, object paramValue);

        /// <summary>
        /// 开始执行事务
        /// </summary>
        public virtual void TransStart()
        {
            OpenConnection();
            DbTransObj = DBConnectionObj.BeginTransaction();
            DbCommandObj.Transaction = DbTransObj;
            _IsTrans = true;
        }
        /// <summary>
        /// 事务提交
        /// </summary>
        public virtual void TransCommit()
        {
            _IsTrans = false;
            DbTransObj.Commit();
            CloseConnect();
        }
        /// <summary>
        /// 事务回滚
        /// </summary>
        public virtual void TransRollback()
        {
            _IsTrans = false;
            DbTransObj.Rollback();
            CloseConnect();
        }
        /// <summary>
        /// 执行一条指定命令类型(SQL语句或存储过程等)的SQL语句,返回所影响行数
        /// </summary>
        public virtual int ExecNonQuery(string sqlText, CommandType cmdType, params DbParameter[] param)
        {
            lock (_LockExecNonQuery)
            {
                try
                {
                    SetCommandAndOpenConnect(sqlText, cmdType, param);
                    return DbCommandObj.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    WriteErrLog(ex, sqlText, param);
                    throw ex;
                }
                finally
                {
                    CloseConnect();
                }
            }
        }
        /// <summary>
        /// 执行一条普通SQL语句的命令,返回所影响行数
        /// </summary>
        public virtual int ExecNonQuery(string sqlText, params DbParameter[] param)
        {
            return ExecNonQuery(sqlText, CommandType.Text, param);
        }
        /// <summary>        
        /// 获得DataReader对象
        /// </summary>
        public virtual DbDataReader GetDataReader(string sqlText, CommandType cmdType, CommandBehavior cmdBehavior, params DbParameter[] param)
        {
            lock (_LockGetDataReader)
            {
                try
                {
                    SetCommandAndOpenConnect(sqlText, cmdType, param);
                    DbDataReader dbReader = DbCommandObj.ExecuteReader(cmdBehavior);
                    return dbReader;
                }
                catch (Exception ex)
                {
                    WriteErrLog(ex, sqlText, param);
                    throw ex;
                }
                finally
                {
                    //DataReader用dbReader对象来关闭,即使非事务也是,不要把注释取消
                    //CloseConnect();
                }
            }
        }
        /// <summary>
        /// 获得DataReader对象
        /// </summary>
        public virtual DbDataReader GetDataReader(string sqlText, CommandType cmdType, params DbParameter[] param)
        {
            CommandBehavior cmdBehavior;
            if (_IsTrans)
            {
                cmdBehavior = CommandBehavior.Default;
            }
            else
            {
                //非事务时,关闭DataReader则关闭当前连接
                cmdBehavior = CommandBehavior.CloseConnection;
            }
            return GetDataReader(sqlText, cmdType, cmdBehavior, param);
        }
        /// <summary>
        /// 执行sql语句返回DataReader对象
        /// </summary>
        public virtual DbDataReader GetDataReader(string sqlText, params DbParameter[] param)
        {
            return GetDataReader(sqlText, CommandType.Text, param);
        }
        /// <summary>
        /// 获得首行首列
        /// </summary>
        public virtual object GetScalar(string sqlText, CommandType cmdType, params DbParameter[] param)
        {
            lock (_LockGetScalar)
            {
                try
                {
                    SetCommandAndOpenConnect(sqlText, cmdType, param);
                    return DbCommandObj.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    WriteErrLog(ex, sqlText, param);
                    throw ex;
                }
                finally
                {
                    CloseConnect();
                }
            }
        }
        /// <summary>
        /// 执行SQL语句,返回首行首列
        /// </summary>
        public virtual object GetScalar(string sqlText, params DbParameter[] param)
        {
            return GetScalar(sqlText, CommandType.Text, param);
        }
        /// <summary>
        /// 执行一条SQL语句返回DataSet对象
        /// </summary>
        public virtual DataSet GetDataSet(string sqlText, CommandType cmdType, params DbParameter[] param)
        {
            lock (_LockGetDataSet)
            {
                try
                {
                    SetCommandAndOpenConnect(sqlText, cmdType, param);
                    DbDataAdapterObj.SelectCommand = DbCommandObj;
                    DataSet ds = new DataSet();
                    DbDataAdapterObj.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    WriteErrLog(ex, sqlText, param);
                    throw ex;
                }
                finally
                {
                    CloseConnect();
                }
            }
        }
        /// <summary>
        /// 执行一条SQL语句返回DataSet对象
        /// </summary>        
        public virtual DataSet GetDataSet(string sqlText, params DbParameter[] param)
        {
            return GetDataSet(sqlText, CommandType.Text, param);
        }
        /// <summary>
        /// 执行一条SQL语句返回DataTable对象(调用GetDataSet)
        /// </summary>        
        public virtual DataTable GetDataTable(string sqlText, params DbParameter[] param)
        {
            return GetDataTable(sqlText, CommandType.Text, param);
        }
        /// <summary>
        /// 执行一条SQL语句返回DataTable对象(调用GetDataSet)
        /// </summary>
        public virtual DataTable GetDataTable(string sqlText, CommandType cmdType, params DbParameter[] param)
        {
            return (GetDataSet(sqlText, cmdType, param)).Tables[0];
        }
    }
}