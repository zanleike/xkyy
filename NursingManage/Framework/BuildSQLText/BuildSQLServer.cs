/*
 * 2017.9.19   解决sqlserver分页查询第一页时的bug，首页查询时未加入where条件
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Reflection;

namespace Framework.BuildSQLText
{
    class BuildSQLServer : BuildSQLBase
    {
        protected internal override string ParamSignStr
        {
            get { return BuildSQLBase.PARAMSIGN_SQLSERVER; }
        }

        ISqlBuilder BuildQueryPager(string tableName, string selectFields, int onePage)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("Select top {0} {1} From {2} ", onePage, selectFields, tableName);
            sql.Append("where {0}");
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText(sql.ToString());
            return result;
        }
        public override string FormatName(string fieldNameOrTableName)
        {
            return string.Format("[{0}]", fieldNameOrTableName);
        }
        public override ISqlBuilder BuildQueryPager(string tableName, string[] fields, int pageNo, int onePage)
        {
            StringBuilder sql = new StringBuilder();
            string selectFields = GetSelectFieldStr(fields);
            tableName = FormatName(tableName);
            if (pageNo == 1)
            {
                return BuildQueryPager(tableName, selectFields, onePage);
            }
            string tmpColumnName = FormatName("rownumber");
            string tmpTableName = FormatName("tmpTable");
            sql.AppendFormat("select top {0} {1} From (Select row_number() over(", onePage, selectFields);
            sql.Append("Order By {1}"); //排序预留
            sql.AppendFormat(") as {0},{1} from {2} ", tmpColumnName, selectFields, tableName);
            sql.Append("Where {0}"); //where条件,如果为空需要赋值1=1
            sql.AppendFormat(") as {0} Where {1} > {2}*({3}-1)",tmpTableName, tmpColumnName, onePage, pageNo);
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText(sql.ToString());
            return result;
        }
        public ISqlBuilder BuildPagerBySql2000(string tableName, string[] fields, int pageNo, int onePage, string pkName)
        {
            StringBuilder sql = new StringBuilder();
            string selectFields = GetSelectFieldStr(fields);
            sql.AppendFormat("Select Top {0} {1} From {2}", onePage, selectFields, tableName);
            pkName = FormatName(pkName);
            tableName = FormatName(tableName);
            sql.AppendFormat("WHERE {0} NOT IN ( ", pkName);
            sql.AppendFormat("SELECT TOP ({0}*({1}-1)) {2} FROM {3} ", onePage, pageNo, pkName, tableName);
            sql.Append("Where {0} "); //where预留
            sql.Append("Order By {1}"); //order by 预留
            sql.Append(")");
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText(sql.ToString());
            return result;
        }
    }

    //public class PagerSQLParam
    //{
    //    /// <summary>
    //    /// where 语句,不包含Where关键字,如果为空则为1=1 ,用来填充{0}
    //    /// </summary>
    //    public string WhereSQL { set; get; }
    //    /// <summary>
    //    /// 占位符{1} ,排序语句,不包含"Order by "
    //    /// </summary>
    //    public string OrderBySQL { set; get; }
    //}
}