using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.BuildSQLText;

namespace Framework.Core
{
    public interface IExecResult
    {
        /// <summary>
        /// 返回执行方法所影响行数
        /// </summary>
        int Count { get; }
        /// <summary>
        /// 返回执行方法的sql文本和参数值的字符串格式
        /// </summary>
        string SQL { get; }
    }

    class ExecResult : IExecResult
    {
        protected internal ExecResult(ISqlBuilder sqlBuilder)
            : this(0, sqlBuilder)
        { }
        protected internal ExecResult(int execCount, ISqlBuilder sqlBuilder)
        {
            this.ExecCount = execCount;
            this.SqlResult = sqlBuilder;
        }

        protected internal string GetExecSQLText()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(SqlResult.SQLText);
            sql.AppendLine();
            if (SqlResult.DbParam != null)
            {
                foreach (var item in SqlResult.DbParam.Keys)
                {
                    sql.AppendFormat("{0}={1};", item, SqlResult.DbParam[item]);
                }
            }
            return sql.ToString();
        }

        protected internal ISqlBuilder SqlResult;

        protected internal int ExecCount;

        public int Count
        {
            get
            {
                return ExecCount;
            }
        }
        string _sql;
        public string SQL
        {
            get
            {
                if (string.IsNullOrEmpty(_sql)) _sql = GetExecSQLText();
                return _sql;
            }
        }
    }
}