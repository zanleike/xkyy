using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.BuildSQLText
{
    class BuildSQLite : BuildSQLBase
    {
        protected internal override string ParamSignStr
        {
            get { return BuildSQLBase.PARAMSIGN_SQLITE; }
        }

        public override string FormatName(string fieldNameOrTableName)
        {
            return string.Format("[{0}]", fieldNameOrTableName);
        }

        public override ISqlBuilder BuildQueryPager(string tableName, string[] fields, int pageNo, int onePage)
        {
            StringBuilder sql = new StringBuilder();
            string searchFieldStr = GetSelectFieldStr(fields);
            sql.AppendFormat("Select {0} From {1} ", searchFieldStr, tableName);

            sql.Append("Where {0} "); //where预留
            sql.Append("Order By {1}"); //order by 预留

            sql.AppendFormat(" limit {0} offset {1}", onePage, onePage * (pageNo - 1));
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText(sql.ToString());
            return result;
        }
    }
}
