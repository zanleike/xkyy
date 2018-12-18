using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.BuildSQLText
{
    class BuildOracle : BuildSQLBase
    {
        protected internal override string ParamSignStr
        {
            get { return BuildSQLBase.PARAMSIGN_ORACLE; }
        }

        //public override SqlBuilder BuildQueryPager(string tableName, string[] fields, int pageNo, int onePage)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    string searchFieldStr = GetSelectFieldStr(fields);
        //    sql.AppendFormat("Select {0} From {1} ", searchFieldStr, tableName);
        //    sql.Append("Where {0} "); //where预留
        //    sql.Append("Order By {1}"); //order by 预留

        //    sql.AppendFormat(" limit {0},{1}", onePage, onePage * (pageNo - 1));
        //    SqlBuilder result = CreateBuildResult();
        //    result.AddSQLText(sql.ToString());
        //    return result;
        //}

        public override string FormatName(string fieldNameOrTableName)
        {
            return string.Format("\"{0}\"", fieldNameOrTableName);
        }

        public override ISqlBuilder BuildQueryPager(string tableName, string[] fields, int pageNo, int onePage)
        {
            StringBuilder sql = new StringBuilder();
            string searchFieldStr = GetSelectFieldStr(fields);
            sql.Append("Select * ");
            sql.Append("FROM (SELECT tt.*, ROWNUM AS rowno ");
            sql.AppendFormat("FROM (  SELECT {0} ", searchFieldStr);
            sql.AppendFormat("FROM {0} t ", tableName);
            sql.Append("Where {0} "); //where预留
            sql.Append("Order By {1}"); //order by 预留
            sql.Append(") tt ");
            sql.AppendFormat("WHERE ROWNUM <= {0}) table_alias ", pageNo * onePage);
            sql.AppendFormat("WHERE table_alias.rowno > {0} ", (pageNo - 1) * onePage);
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText(sql.ToString());
            return result;
        }
    }
}
