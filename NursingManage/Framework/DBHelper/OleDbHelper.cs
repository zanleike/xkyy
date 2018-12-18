using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using Framework.BuildSQLText;

namespace Framework.DBHelper
{
    public class OleDbHelper : DbHelperBase
    {
        public OleDbHelper(string connStr)
            : base(connStr)
        { }

        OleDbConnection _DBConnectionObj;
        OleDbCommand _DbCommandObj;
        OleDbDataAdapter _DbDataAdapterObj;

        protected override DbConnection DBConnectionObj
        {
            get
            {
                //SqlBulkCopy aa = new SqlBulkCopy(new SqlConnection());
                if (_DBConnectionObj == null)
                {
                    _DBConnectionObj = new OleDbConnection(_ConnStr);
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
                    _DbCommandObj = new OleDbCommand();
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
                    _DbDataAdapterObj = new OleDbDataAdapter();
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
        //        paramList.Add(new OleDbParameter(item, paramObj[item]));
        //    }
        //    return paramList.ToArray();
        //}        
        public override DbParameter CreateDbParameter(string paramName, object paramValue)
        {
            if (paramName.Substring(0, 1) != BuildSQLBase.PARAMSIGN_OLEDB)
            {
                paramName = string.Format("{1}{0}", paramName, BuildSQLBase.PARAMSIGN_OLEDB);
            }
            return new OleDbParameter(paramName, paramValue);
        }
    }
}