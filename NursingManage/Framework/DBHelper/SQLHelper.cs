using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using Framework.BuildSQLText;

namespace Framework.DBHelper
{
    public class SQLHelper : DbHelperBase
    {
        public SQLHelper(string connStr)
            : base(connStr)
        { }

        SqlConnection _DBConnectionObj;
        SqlCommand _DbCommandObj;
        SqlDataAdapter _DbDataAdapterObj;

        protected override DbConnection DBConnectionObj
        {
            get
            {
                //SqlBulkCopy aa = new SqlBulkCopy(new SqlConnection());
                if (_DBConnectionObj == null)
                {
                    _DBConnectionObj = new SqlConnection(_ConnStr);
                }
                return _DBConnectionObj;
            }
        }
        protected override DbCommand DbCommandObj
        {
            get
            {
                if (_DbCommandObj == null)
                {
                    _DbCommandObj = new SqlCommand();
                }
                return _DbCommandObj;
            }
        }
        protected override DbDataAdapter DbDataAdapterObj
        {
            get
            {
                if (_DbDataAdapterObj == null)
                {
                    _DbDataAdapterObj = new SqlDataAdapter();
                }
                return _DbDataAdapterObj;
            }
        }
        //public override DbParameter[] ConvertDbParameter(Dictionary<string, object> paramObj)
        //{
        //    if (paramObj == null) return null;
        //    List<DbParameter> paramList = new List<DbParameter>();
        //    foreach (var item in paramObj.Keys)
        //    {
        //        paramList.Add(new SqlParameter(item, paramObj[item]));
        //    }
        //    return paramList.ToArray();
        //}
        public override DbParameter CreateDbParameter(string paramName, object paramValue)
        {
            if (paramName.Substring(0, 1) != BuildSQLBase.PARAMSIGN_SQLSERVER)
            {
                paramName = string.Format("{1}{0}", paramName, BuildSQLBase.PARAMSIGN_SQLSERVER);
            }
            return new SqlParameter(paramName, paramValue);
        }
    }
}