using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Framework.BuildSQLText;

namespace Framework.DBHelper
{
    public class MySqlDbHelper : DbHelperBase
    {
        public MySqlDbHelper(string connStr)
            : base(connStr)
        { }

        MySqlConnection _DBConnectionObj;
        MySqlCommand _DbCommandObj;
        MySqlDataAdapter _DbDataAdapterObj;

        protected override DbConnection DBConnectionObj
        {
            get
            {
                //SqlBulkCopy aa = new SqlBulkCopy(new SqlConnection());
                if (_DBConnectionObj == null)
                {
                    _DBConnectionObj = new MySqlConnection(_ConnStr);
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
                    _DbCommandObj = new MySqlCommand();
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
                    _DbDataAdapterObj = new MySqlDataAdapter();
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
        //        paramList.Add(new MySqlParameter(item, paramObj[item]));
        //    }
        //    return paramList.ToArray();
        //}
        public override DbParameter CreateDbParameter(string paramName, object paramValue)
        {
            if (paramName.Substring(0, 1) != BuildSQLBase.PARAMSIGN_MYSQL)
            {
                paramName = string.Format("{1}{0}", paramName, BuildSQLBase.PARAMSIGN_MYSQL);
            }
            return new MySqlParameter(paramName, paramValue);
        }
    }
}