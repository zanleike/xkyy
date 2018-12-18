using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.BuildSQLText
{
    class BuildOleDb : BuildSQLBase
    {
        protected internal override string ParamSignStr
        {
            get { return BuildSQLBase.PARAMSIGN_OLEDB; }
        }

        public override string FormatName(string fieldNameOrTableName)
        {
            return string.Format("[{0}]", fieldNameOrTableName);
        }

        public override ISqlBuilder BuildQueryPager(string tableName, string[] fields, int pageNo, int onePage)
        {
            throw new NotImplementedException();
        }
    }
}
