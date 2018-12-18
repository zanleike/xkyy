using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Framework.BuildSQLText;
using Oracle.ManagedDataAccess.Client;

namespace Framework.Entitys
{
    /// <summary>
    /// 存储过程参数的特性类
    /// </summary>
    public class ProcedureParamAttribute : Attribute
    {
        public ProcedureParamAttribute()
        {
            _ParamDirection = ParameterDirection.Input;
            _OutSize = 50;
        }
        public ProcedureParamAttribute(ParameterDirection paramDirection)
        {
            _ParamDirection = paramDirection;
        }

        ParameterDirection _ParamDirection;
        /// <summary>
        /// 存储过程输出参数的方向类型
        /// </summary>
        public ParameterDirection ParamDirection
        {
            get { return _ParamDirection; }
            set { _ParamDirection = value; }
        }
        int _OutSize;
        /// <summary>
        /// 输出参数的字节数,默认50个字节
        /// </summary>
        public int OutSize
        {
            get { return _OutSize; }
            set { _OutSize = value; }
        }
        /// <summary>
        /// 是否oracle游标类型
        /// </summary>
        public bool IsOracleCursor { set; get; }
        //public string ProcedureName { set; get; }
        /// <summary>
        /// 参数名，空则使用属性名代表参数名
        /// </summary>
        public string ParameterName { set; get; }
        /// <summary>
        /// true表示非存储过程参数
        /// </summary>
        public bool NotParameter { set; get; }
    }

    public class ProcedureEntiryBase
    {
        protected virtual string ProcedureName { get; private set; }
        /// <summary>
        /// 获取存储过程名称
        /// </summary>
        public string GetProcedureName()
        {
            if (string.IsNullOrWhiteSpace(ProcedureName))
            {
                string className = this.GetType().Name;
                string fistStr = "";
                ProcedureName = className.Substring(fistStr.Length, className.Length - fistStr.Length);
            }
            return ProcedureName;
        }
        /// <summary>
        /// 输出参数的属性字典,key包含@
        /// </summary>
        // Dictionary<object, ProcedureParamAttribute> _OutAttrParamDict;

        List<OutParam> _OutParamList = new List<OutParam>();

        class OutParam
        {
            public string PropertyName { set; get; }
            public string ParameterName { set; get; }
        }

        /// <summary>
        /// 获得存储过程参数集合
        /// </summary>
        public virtual DbParameter[] GetProcParamObj(Func<string, object, DbParameter> CreateDbParameterHandle)
        {
            var procParam = new List<DbParameter>();
            Type t = this.GetType();
            System.Reflection.PropertyInfo[] pros = t.GetProperties();
            _OutParamList.Clear();
            foreach (System.Reflection.PropertyInfo item in pros)
            {
                Attribute attr = ProcedureParamAttribute.GetCustomAttribute(item, typeof(ProcedureParamAttribute));
                ProcedureParamAttribute paramAttr = attr as ProcedureParamAttribute;
                if (paramAttr == null)
                {
                    paramAttr = new ProcedureParamAttribute();
                }
                else
                {
                    if (paramAttr.NotParameter) continue;
                }
                if (string.IsNullOrWhiteSpace(paramAttr.ParameterName))
                {
                    paramAttr.ParameterName = item.Name;
                }
                object paramValue = item.GetValue(this, null);
                DbParameter param = CreateDbParameterHandle(paramAttr.ParameterName, paramValue);
                param.Direction = paramAttr.ParamDirection;
                param.Size = paramAttr.OutSize;
                if (paramAttr.IsOracleCursor)
                {
                    //oracle 返回datatable必须指定一个游标类型的参数用来输出
                    Type oracleParamType = param.GetType();
                    var oclDbType = oracleParamType.GetProperty("OracleDbType");
                    oclDbType.SetValue(param, OracleDbType.RefCursor, null);
                }
                procParam.Add(param);
                if (paramAttr.ParamDirection == ParameterDirection.InputOutput || paramAttr.ParamDirection == ParameterDirection.Output)
                {
                    _OutParamList.Add(new OutParam() { ParameterName = param.ParameterName, PropertyName = item.Name });
                }
            }
            return procParam.ToArray();
        }
        /// <summary>
        /// 给当前对象设置输出参数的值
        /// </summary>
        public virtual void SetOutParamValue(DbParameter[] dbParams)
        {
            if (dbParams == null || dbParams.Length == 0) return;
            Type t = this.GetType();
            foreach (var item in _OutParamList)
            {
                System.Reflection.PropertyInfo pro = t.GetProperty(item.PropertyName);
                var param = dbParams.First(s => s.ParameterName == item.ParameterName);
                if (param != null && param.Value != DBNull.Value)
                {
                    pro.SetValue(this, param.Value, null);
                }
            }
        }
    }
}
