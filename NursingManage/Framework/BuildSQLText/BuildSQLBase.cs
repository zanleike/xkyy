/*
    创建日期: 2015.8.18
    创建者:张存
    邮箱:zhangcunliang@126.com
    说明:
        用于生成sql文本,不同数据库类型的差异由子类重写.
    修改记录:
        insert语句由 select 改为values oracle 不支持select 语法 2017.3.20
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.BuildSQLText
{
    public abstract class BuildSQLBase
    {
        public const string PARAMSIGN_SQLSERVER = "@";
        public const string PARAMSIGN_MYSQL = "?";
        public const string PARAMSIGN_SQLITE = PARAMSIGN_SQLSERVER;
        public const string PARAMSIGN_ORACLE = ":";
        public const string PARAMSIGN_OLEDB = PARAMSIGN_SQLSERVER;

        protected readonly string ParamNameKey = "B";

        protected internal abstract string ParamSignStr { get; }

        public virtual string FormatName(string fieldNameOrTableName)
        {
            return fieldNameOrTableName;
        }

        protected internal virtual ISqlBuilder CreateBuildResult(string paramKey)
        {
            return SqlBuilder.Create(ParamSignStr, paramKey);
        }
        protected internal virtual ISqlBuilder CreateBuildResult()
        {
            return CreateBuildResult(string.Empty);
        }
        /// <summary>
        /// 获得数据库用的字段格式,[Id],[Name],[Age]
        /// </summary>        
        protected string GetSelectFieldStr(string[] fields)
        {
            if (fields == null || fields.Length == 0) throw new ArgumentNullException("fields");
            StringBuilder fdStr = new StringBuilder();
            for (int i = 0; i < fields.Length ; i++)
            {
                //fdStr.AppendFormat("[{0}],", fieldArr[i]);
                //2013.11.10 去掉查询时字段的"[]"(中括号),是因为SQLite冲突,
                //如果需要sql server 中加上[] 那么可在SQLite中重写该方法
                fdStr.AppendFormat("{0}", FormatName(fields[i]));
                if (i < fields.Length - 1)
                {
                    fdStr.Append(",");
                }
            }
            return fdStr.ToString();
        }
        //生成,where Name=@name and Age=@age 类似的where条件 ,以equalFields为主
        public virtual void BuildEqualWhere(ISqlBuilder sqlBuilder, Dictionary<string, object> fieldValues, string[] equalFields)
        {
            if (equalFields == null || equalFields.Length == 0) return;
            string pkName;
            object pkValue;
            string paramName;
            StringBuilder where = new StringBuilder();
            where.AppendFormat(" where");
            for (int i = 0; i < equalFields.Length; i++)
            {
                pkName = equalFields[i];
                if (!fieldValues.ContainsKey(pkName) || fieldValues[pkName] == null) continue;
                pkValue = fieldValues[pkName];
                paramName = sqlBuilder.AddParam(pkValue);
                where.AppendFormat(" {0}={1}", FormatName(pkName), paramName);
                if (i < equalFields.Length - 1)
                {
                    where.AppendFormat(" and");
                }
            }
            if (where.Length > 7)
            {
                sqlBuilder.AddSQLText(where.ToString());
            }
        }

        public virtual ISqlBuilder BuildInsert(string tableName, Dictionary<string, object> fieldValues)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException("tableName");
            }
            if (fieldValues == null)
            {
                throw new ArgumentNullException("fieldValues");
            }
            string[] fields = fieldValues.Keys.ToArray();
            string selectStr = GetSelectFieldStr(fields);
            ISqlBuilder result = CreateBuildResult();
            tableName = FormatName(tableName);
            result.AddSQLText("Insert into {0} ({1})", tableName, selectStr);
            //result.AddSQLText("Select ");
            result.AddSQLText("values (");
            for (int i = 0; i < fields.Length; i++)
            {
                string paramName = result.AddParam(fieldValues[fields[i]]);
                result.AddSQLText(paramName);
                if (i < fields.Length - 1) result.AddSQLText(",");
            }
            result.AddSQLText(")");
            return result;
        }
        public virtual ISqlBuilder BuildUpdate(string tableName, Dictionary<string, object> fieldValues, params string[] pkNames)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException("tableName");
            }
            if (fieldValues == null)
            {
                throw new ArgumentNullException("fieldValues");
            }
            ISqlBuilder result = CreateBuildResult();
            tableName = FormatName(tableName);
            result.AddSQLText("Update {0} ", tableName);
            result.AddSQLText("Set ");
            //string[] updatefields = fieldValues.Keys.ToArray();
            List<string> updateFields = new List<string>();
            foreach (var item in fieldValues.Keys)
            {
                if (pkNames.Contains(item)) continue;
                updateFields.Add(item);
            }

            for (int i = 0; i < updateFields.Count; i++)
            {
                object paramValue = fieldValues[updateFields[i]];
                string paramName = result.AddParam(paramValue);
                string fieldName = FormatName(updateFields[i]);
                result.AddSQLText("{0}={1}", fieldName, paramName);
                if (i < updateFields.Count - 1) result.AddSQLText(",");
            }
            BuildEqualWhere(result, fieldValues, pkNames);
            return result;
        }
        public virtual ISqlBuilder BuildDelete(string tableName, Dictionary<string, object> fieldValues, params string[] pkNames)
        {
            tableName = FormatName(tableName);
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText("Delete From {0}", tableName);
            BuildEqualWhere(result, fieldValues, pkNames);
            return result;
        }
        public virtual ISqlBuilder BuildQuery(string tableName, string[] fields)
        {
            string selectStr = GetSelectFieldStr(fields);
            tableName = FormatName(tableName);
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText("Select {0} From {1}", selectStr, tableName);
            return result;
        }
        protected virtual ISqlBuilder BuildFunction(string tableName, string fieldName, string functionName)
        {
            tableName = FormatName(tableName);
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText("Select {0}({1}) From {2}", functionName, fieldName, tableName);
            return result;
        }
        public virtual ISqlBuilder BuildMaxFunction(string tableName, string fieldName)
        {
            return BuildFunction(tableName, fieldName, "Max");
        }
        public virtual ISqlBuilder BuildMinFunction(string tableName, string fieldName)
        {
            return BuildFunction(tableName, fieldName, "Min");
        }
        public virtual ISqlBuilder BuildSumFunction(string tableName, string fieldName)
        {
            return BuildFunction(tableName, fieldName, "Sum");
        }
        public virtual ISqlBuilder BuildCountFunction(string tableName)
        {
            tableName = FormatName(tableName);
            ISqlBuilder result = CreateBuildResult();
            result.AddSQLText("Select Count(1) From {0}", tableName);
            return result;
        }
        public abstract ISqlBuilder BuildQueryPager(string tableName, string[] fields, int pageNo, int onePage);
    }
}