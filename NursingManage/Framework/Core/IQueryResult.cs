/*
    2017.5.25 QueryResult<TEntity> 重写ToDataTable() 方法，赋值表名
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Linq.Expressions;
using Framework.Entitys;
using Framework.BuildSQLText;
using Framework.DBHelper;
using System.Data.Common;

namespace Framework.Core
{
    public interface IQueryResult : IExecResult
    {
        /// <summary>
        /// 执行数据库操作并返回DataTable结果
        /// </summary>
        DataTable ToDataTable();
    }
    public interface IQueryResult<TEntity> : IQueryResult where TEntity : EntityBase, new()
    {
        /// <summary>
        /// 执行数据库查询并返回强类型List列表
        /// </summary>
        List<TEntity> ToList();
        /// <summary>
        /// 执行数据库查询返回首行实体对象
        /// </summary>
        TEntity ToEntity();
    }
    class QueryResult : ExecResult, IQueryResult
    {
        public QueryResult(IDbHelper dbHelper, ISqlBuilder sqlBuilder)
            : base(sqlBuilder)
        {
            this._DbHelper = dbHelper;
        }
        protected IDbHelper _DbHelper;

        public virtual DataTable ToDataTable()
        {
            DbParameter[] param = _DbHelper.ConvertDbParameter(SqlResult.DbParam);
            DataTable dt = _DbHelper.GetDataTable(SqlResult.SQLText, param);
            base.ExecCount = dt != null ? dt.Rows.Count : 0;
            return dt;
        }
    }
    class QueryResult<TEntity> : QueryResult, IQueryResult<TEntity> where TEntity : EntityBase, new()
    {
        public QueryResult(IDbHelper dbHelper, ISqlBuilder sqlBuilder)
            : base(dbHelper, sqlBuilder)
        { }
        /// <summary>
        /// 返回该实体对象的表名
        /// </summary>
        public string TableName { get; internal set; }

        #region 运行查询List正常则可删除，不正常比较

        ///// <summary>
        ///// 将DataReader转换为List对象
        ///// </summary>
        //protected virtual List<TEntity> GetListByDataReader(DbDataReader dbReader, bool isFirst)
        //{
        //    if (dbReader == null) return null;
        //    List<TEntity> list = new List<TEntity>();
        //    using (dbReader)
        //    {
        //        if (dbReader.HasRows)
        //        {
        //            DataTable schemaTable = dbReader.GetSchemaTable();
        //            DataRow[] schemaRow;
        //            Type type = typeof(TEntity);
        //            System.Reflection.PropertyInfo[] pros = type.GetProperties();
        //            while (dbReader.Read())
        //            {
        //                TEntity model = new TEntity();

        //                if (pros == null || pros.Length == 0) break;
        //                foreach (var item in pros)
        //                {
        //                    if (!item.CanWrite) continue;
        //                    string sName = item.Name;
        //                    //判断实体中的属性是否存在该列名,不存在则跳出循环
        //                    schemaRow = schemaTable.Select(string.Format("ColumnName='{0}'", sName));
        //                    if (schemaRow.Length == 0) continue;
        //                    object obj = dbReader[sName];

        //                    if (obj != null && obj != DBNull.Value && obj.ToString().Trim() != string.Empty)
        //                    {
        //                        if (obj.GetType() != item.PropertyType)
        //                        {
        //                            string propertyTypeName = item.PropertyType.Name.ToUpper();

        //                            switch (propertyTypeName)
        //                            {
        //                                case "GUID":
        //                                    obj = new Guid(obj.ToString());
        //                                    break;
        //                                default:
        //                                    obj = Convert.ChangeType(obj, item.PropertyType);
        //                                    break;
        //                            }
        //                        }
        //                        //这句话出现异常后,看看是什么类型转换失败,加到分支里面                                
        //                        item.SetValue(model, obj, null);
        //                    }
        //                }
        //                model.ClearChangedState();
        //                list.Add(model);
        //                if (isFirst) break;
        //            }
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //        return list;
        //    }
        //}
        
        #endregion
        
        protected virtual List<TEntity> GetListByDataReader(DbDataReader dbReader)
        {
            return ReflectionHelper.GetListByDataReader<TEntity>(dbReader, false);
        }
        protected List<TEntity> ToList(bool isFirst)
        {
            DbParameter[] param = _DbHelper.ConvertDbParameter(SqlResult.DbParam);
            DbDataReader reader = _DbHelper.GetDataReader(SqlResult.SQLText, param);
            List<TEntity> rList = ReflectionHelper.GetListByDataReader<TEntity>(reader, isFirst);
            base.ExecCount = rList != null ? rList.Count : 0;
            return rList;
        }
        public List<TEntity> ToList()
        {
            return ToList(false);
        }
        public TEntity ToEntity()
        {
            List<TEntity> rList = ToList(true);
            if (rList != null && rList.Count > 0)
            {
                return rList[0];
            }
            else
            {
                return null;
            }
        }
        public override DataTable ToDataTable()
        {
            DataTable dt = base.ToDataTable();
            if (!string.IsNullOrWhiteSpace(TableName))
            {
                dt.TableName = TableName;
            }
            return dt;
        }
    }
}