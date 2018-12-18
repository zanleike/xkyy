/*
    2017.07.14 创建存储过程返回对象，所有执行存储过程的返回的结果都有该对象赋值
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework.Entitys;
using Framework.DBHelper;

namespace Framework.Core
{
    public class IProcResult
    {
        protected internal IProcResult(IDbHelper dbHelper, ProcedureEntiryBase procModel)
        {
            this._DbHelper = dbHelper;
            this._ProcModel = procModel;
        }
        IDbHelper _DbHelper;
        ProcedureEntiryBase _ProcModel;
        /// <summary>
        /// 执行数量
        /// </summary>
        public virtual int ExecCount { get; private set; }
        public virtual int ExecProc()
        {
            string procName = _ProcModel.GetProcedureName();
            var procParams = _ProcModel.GetProcParamObj(_DbHelper.CreateDbParameter);
            ExecCount = _DbHelper.ExecNonQuery(procName, CommandType.StoredProcedure, procParams);
            _ProcModel.SetOutParamValue(procParams);
            return ExecCount;
        }
        public virtual DataTable ToDataTable()
        {
            string procName = _ProcModel.GetProcedureName();
            var procParams = _ProcModel.GetProcParamObj(_DbHelper.CreateDbParameter);
            var r = _DbHelper.GetDataTable(procName, CommandType.StoredProcedure, procParams);
            _ProcModel.SetOutParamValue(procParams);
            return r;
        }

        protected List<TEntity> ToList<TEntity>(bool isFirst) where TEntity : class, new()
        {
            string procName = _ProcModel.GetProcedureName();
            var procParams = _ProcModel.GetProcParamObj(_DbHelper.CreateDbParameter);
            var dbReader = _DbHelper.GetDataReader(procName, CommandType.StoredProcedure, procParams);
            _ProcModel.SetOutParamValue(procParams);
            var rList = ReflectionHelper.GetListByDataReader<TEntity>(dbReader, isFirst);
            return rList;
        }
        public List<TEntity> ToList<TEntity>() where TEntity : class, new()
        {
            return ToList<TEntity>(false);
        }
        public TEntity ToEntity<TEntity>() where TEntity : class, new()
        {
            List<TEntity> rList = ToList<TEntity>(true);
            if (rList != null && rList.Count > 0)
            {
                return rList[0];
            }
            else
            {
                return null;
            }
        }
    }
}