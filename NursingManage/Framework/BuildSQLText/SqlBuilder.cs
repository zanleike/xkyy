using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.BuildSQLText
{
    public class SqlBuilder : IDisposable, ISqlBuilder
    {
        public static ISqlBuilder Create(string paramSignStr, string paramKey)
        {
            return new SqlBuilder(paramSignStr, paramKey);
        }
        private SqlBuilder(string paramSignStr)
            : this(paramSignStr, string.Empty)
        { }

        private SqlBuilder(string paramSignStr, string paramKey)
        {
            _ParamSignStr = paramSignStr;
            _ParamKey = paramKey;
            _SQL = new StringBuilder();
        }

        int _ParamCount = 0;
        string _ParamSignStr;
        string _ParamKey;
        StringBuilder _SQL;
        Dictionary<string, object> _DbParam;


        public string SQLText
        {
            get { return _SQL.ToString(); }
        }
        public Dictionary<string, object> DbParam
        {
            get
            {
                return _DbParam;
            }
        }
        /// <summary>
        /// 追加sql文本，支持string.format 方法；
        /// </summary>
        public void AddSQLText(string sql, params object[] args)
        {
            if (args == null || args.Length == 0)
            {
                _SQL.Append(sql);
            }
            else
            {
                _SQL.AppendFormat(sql, args);
            }
        }
        /// <summary>
        /// 追加sql文本，支持string.format 方法，同时会把所有已有条件加上括号，并加上and符号
        /// </summary>
        public void AddSqlTextByGroup(string sql, params object[] args)
        {
            if (args == null || args.Length == 0)
            {
                _SQL.Append(sql);
            }
            else
            {
                if (sql.Length > 2)
                {
                    _SQL.Insert(0, "(");
                    _SQL.Append(")");
                    _SQL.Append(" and ");
                }
                _SQL.AppendFormat(sql, args);
            }
        }
        public string AddParam(object dbParam)
        {
            if (_DbParam == null) _DbParam = new Dictionary<string, object>();
            string paramName = string.Format("{0}{1}{2}", _ParamSignStr, _ParamKey, _ParamCount);
            if (dbParam == null) dbParam = DBNull.Value;
            _DbParam.Add(paramName, dbParam);
            _ParamCount++;
            return paramName;
        }
        /// <summary>
        /// 清除sql脚本和参数
        /// </summary>
        public void ClearResult()
        {
            ClearSQL();
            if (_DbParam != null) _DbParam.Clear();
            _ParamCount = 0;
        }
        /// <summary>
        /// 只清除sql脚本
        /// </summary>
        public void ClearSQL()
        {
            _SQL.Clear();
        }
        public void Dispose()
        {
            ClearResult();
        }
        public void AppendDbParam(Dictionary<string, object> dbParam)
        {
            if (_DbParam == null)
            {
                _DbParam = new Dictionary<string, object>();
            }
            if (dbParam != null)
            {
                foreach (var item in dbParam.Keys)
                {
                    _DbParam.Add(item, dbParam[item]);
                }
            }
        }
    }
}