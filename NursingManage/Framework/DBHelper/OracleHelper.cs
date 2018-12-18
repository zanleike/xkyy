using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;
using Framework.BuildSQLText;

namespace Framework.DBHelper
{
    public class OracleHelper : DbHelperBase
    {
        public OracleHelper(string connStr)
            : base(connStr)
        { }

        OracleConnection _DBConnectionObj;
        OracleCommand _DbCommandObj;
        OracleDataAdapter _DbDataAdapterObj;

        protected override DbConnection DBConnectionObj
        {
            get
            {
                //SqlBulkCopy aa = new SqlBulkCopy(new SqlConnection());
                if (_DBConnectionObj == null)
                {
                    _DBConnectionObj = new OracleConnection(_ConnStr);
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
                    _DbCommandObj = new OracleCommand();
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
                    _DbDataAdapterObj = new OracleDataAdapter();
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
        //        paramList.Add(new OracleParameter(item, paramObj[item]));
        //    }
        //    return paramList.ToArray();
        //}

        public override DbParameter CreateDbParameter(string paramName, object paramValue)
        {
            if (paramName.Substring(0, 1) != BuildSQLBase.PARAMSIGN_ORACLE)
            {
                paramName = string.Format("{1}{0}", paramName, BuildSQLBase.PARAMSIGN_ORACLE);
            }
            return new OracleParameter(paramName, paramValue);
        }
        public override System.Data.DataSet GetDataSet(string sqlText, System.Data.CommandType cmdType, params DbParameter[] param)
        {
            //if (cmdType == System.Data.CommandType.StoredProcedure)
            //{
            //    foreach (var item in param)
            //    {   
            //        if (item.Direction == System.Data.ParameterDirection.Output || item.Direction == System.Data.ParameterDirection.InputOutput)
            //        {
            //            var dbParam = item as OracleParameter;
            //            dbParam.OracleDbType = OracleDbType.RefCursor;
            //        }
            //    }
            //}
            return base.GetDataSet(sqlText, cmdType, param);
        }
        public override DbDataReader GetDataReader(string sqlText, System.Data.CommandType cmdType, System.Data.CommandBehavior cmdBehavior, params DbParameter[] param)
        {
            //if (cmdType == System.Data.CommandType.StoredProcedure)
            //{
            //    foreach (var item in param)
            //    {
            //        if (item.Direction == System.Data.ParameterDirection.Output || item.Direction == System.Data.ParameterDirection.InputOutput)
            //        {
            //            var dbParam = item as OracleParameter;
            //            dbParam.OracleDbType = OracleDbType.RefCursor;
            //        }
            //    }
            //}
            return base.GetDataReader(sqlText, cmdType, cmdBehavior, param);
        }
    }
}