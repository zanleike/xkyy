using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.DBHelper;
using Framework.BuildSQLText;

namespace Framework.Core
{
    public interface IScalarResult
    {
        /// <summary>
        /// 查询首行首列返回一个object
        /// </summary>
        object ToObject();
        /// <summary>
        /// 查询首行首列返回一个实体类对象
        /// </summary>
        /// <typeparam name="T">实体类对象类型</typeparam>        
        T ToObject<T>();
    }

    class ScalarResult : ExecResult, IScalarResult
    {
        public ScalarResult(IDbHelper dbHelper, ISqlBuilder sqlBuilder)
            : base(sqlBuilder)
        {
            this._DbHelper = dbHelper;
            this._SqlResult = sqlBuilder;
        }

        IDbHelper _DbHelper;
        ISqlBuilder _SqlResult;

        public object ToObject()
        {
            var dbParam = _DbHelper.ConvertDbParameter(SqlResult.DbParam);
            object obj = _DbHelper.GetScalar(SqlResult.SQLText, dbParam);
            base.ExecCount = (obj == null || obj is DBNull) ? 0 : 1;
            return obj;
        }

        public T ToObject<T>()
        {
            object obj = ToObject();
            if (obj == null || obj is DBNull)
            {
                return default(T);
            }
            object result = Convert.ChangeType(obj, typeof(T));
            return (T)result;
        }
    }
}
