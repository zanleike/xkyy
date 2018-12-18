/*
创建日期: 2015.8.18
    创建者:张存
    邮箱:zhangcunliang@126.com
    说明:
        数据库上下文,用于操作数据的核心类,也是用户所使用的公共实现
    修改记录: 
        2015.9.9 按实体对象更新时主键未赋值,会更新全部数据的bug修复.
        2015.10.28  增加检查存在的方法实现(扩展于QueryCount方法)
        2015.11.6   调用 Update<TEntity>(TEntity entity, Expression<Func<TEntity, bool>> whereExpress) 默认表达式重载的问题,会默认检测到Update<TEntity>(TEntity entity, Func<SqlBuilder, string> whereFun)
        2016.4.27   insert 方法始终会忽略自增长主键的字段.
        2016.8.29   增加 IScalarResult QueryWhereScalar(SqlBuilder sqlBuilder)
        2017.4.26   合并sqlbuilder与表达式后的分页处理得到count处理的bug
        2017.9.19   解决sqlserver分页查询第一页时的bug，首页查询时未加入where条件
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Common;
using System.Data;
using Framework.DBHelper;
using Framework.BuildSQLText;
using Framework.Entitys;
using Framework.ExpressionAnaly;

namespace Framework.Core
{
    public class DBContext : IDBContext
    {
        public DBContext(EmDatabaseType dbType, string connStr)
        {
            _DBHelper = ContextFactory.Instance.CreateDbHelper(dbType, connStr);
            _BuildSql = ContextFactory.Instance.CreateBuildSQL(dbType);
            _EntityAnaly = ContextFactory.Instance.CreateEntityAnaly();
            _ExprAnaly = ContextFactory.Instance.CreateExpressionAnaly();
        }

        IDbHelper _DBHelper;
        BuildSQLBase _BuildSql;
        IEntityAnaly _EntityAnaly;
        IExpressionAnaly _ExprAnaly;

        protected IDbHelper DbHelper
        {
            get
            {
                return _DBHelper;
            }
        }

        protected Dictionary<string, object> GetEntityValue<TEntity>(TEntity entity, bool isContinuePK) where TEntity : EntityBase, new()
        {
            string[] changedFields = entity.GetChangedFields();

            Dictionary<string, object> fieldValues = new Dictionary<string, object>();
            EntityAttribute entityAttr;
            foreach (var fieldName in changedFields)
            {
                object v = _EntityAnaly.GetPropertyValue(entity, fieldName);
                entityAttr = _EntityAnaly.GetAttribute(entity, fieldName);
                if (isContinuePK && entityAttr.IsIdentity) continue;
                fieldValues.Add(fieldName, v);
            }
            return fieldValues;
        }
        protected Dictionary<string, object> GetEntityValue<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            return GetEntityValue(entity, false);
        }

        public IQueryCondition CreateQueryCondition()
        {
            return new QueryCondition();
        }
        public IQueryCondition<TEntity> CreateQueryCondition<TEntity>() where TEntity : EntityBase, new()
        {
            return new QueryCondition<TEntity>();
        }

        public ICondition CreateExecCondition()
        {
            return new ExecCondition();
        }
        public ICondition<TEntity> CreateExecCondition<TEntity>() where TEntity : EntityBase, new()
        {
            return new ExecCondition<TEntity>();
        }

        public virtual ISqlBuilder CreateSqlBuilder()
        {
            return _BuildSql.CreateBuildResult();
        }
        public virtual ISqlBuilder CreateSqlBuilder(string paramKey)
        {
            return _BuildSql.CreateBuildResult(paramKey);
        }

        public void TransStart()
        {
            _DBHelper.TransStart();
        }
        public void TransCommit()
        {
            _DBHelper.TransCommit();
        }
        public void TransRollback()
        {
            _DBHelper.TransRollback();
        }

        public virtual IExecResult ExecSql(ISqlBuilder sqlBuilder)
        {
            DbParameter[] dbParam = _DBHelper.ConvertDbParameter(sqlBuilder.DbParam);
            int count = _DBHelper.ExecNonQuery(sqlBuilder.SQLText, dbParam);
            IExecResult result = new ExecResult(count, sqlBuilder);
            return result;
        }

        protected virtual IExecResult ExecSql(ISqlBuilder sqlBuilder, string sqlWhere)
        {
            if (!string.IsNullOrEmpty(sqlWhere))
            {
                sqlBuilder.AddSQLText(" where {0}", sqlWhere);
            }
            return ExecSql(sqlBuilder);
        }
        public virtual IExecResult Insert<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            Dictionary<string, object> entityValue = GetEntityValue(entity, true);
            ISqlBuilder sqlBuilder = _BuildSql.BuildInsert(tbName, entityValue);
            entity.ClearChangedState();
            return ExecSql(sqlBuilder, null);
        }
        public virtual IExecResult Update<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            string[] pkNames = _EntityAnaly.GetPrimaryKey<TEntity>();
            entity.SetFieldChanged(pkNames[0]);
            Dictionary<string, object> entityValue = GetEntityValue(entity);
            ISqlBuilder sqlBuilder = _BuildSql.BuildUpdate(tbName, entityValue, pkNames);
            entity.ClearChangedState();
            return ExecSql(sqlBuilder, null);
        }
        public virtual IExecResult Update<TEntity>(TEntity entity, Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new()
        {
            return
            Update(entity, (sqlBuilder) =>
            {
                _ExprAnaly.AnalyWhereExpression<TEntity>(whereExpress, _BuildSql.FormatName, sqlBuilder.AddParam);
                string exprSql = _ExprAnaly.GetValue();
                return exprSql;
            });
        }
        public virtual IExecResult Update<TEntity>(TEntity entity, ICondition execCondition) where TEntity : EntityBase, new()
        {
            return
            Update(entity, (sqlBuilder) =>
            {
                string exprSql = WhereJoin<TEntity>(execCondition.WhereResult, sqlBuilder);
                return exprSql;
            });
        }
        //2015.11.6 注意这个方法的代码只能放到以上另个update方法下面,否则s=>s. 后面会调出SqlBuilder成员
        protected virtual IExecResult Update<TEntity>(TEntity entity, Func<ISqlBuilder, string> whereFun) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            Dictionary<string, object> entityValue = GetEntityValue(entity, true);
            ISqlBuilder sqlBuilder = _BuildSql.BuildUpdate(tbName, entityValue);
            string exprSql = whereFun(sqlBuilder);
            entity.ClearChangedState();
            return ExecSql(sqlBuilder, exprSql);
        }

        public virtual IExecResult Delete<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            string[] pkNames = _EntityAnaly.GetPrimaryKey<TEntity>();
            entity.SetFieldChanged(pkNames[0]);
            Dictionary<string, object> entityValue = GetEntityValue(entity);
            ISqlBuilder sqlBuilder = _BuildSql.BuildDelete(tbName, entityValue, pkNames);
            return ExecSql(sqlBuilder, null);
        }

        /// <summary>
        /// 使用表达式删除的基本方法
        /// </summary>
        protected virtual IExecResult DeleteBase<TEntity>(Func<ISqlBuilder, string> whereFun) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            ISqlBuilder sqlBuilder = _BuildSql.BuildDelete(tbName, null, null);
            string exprSql = whereFun(sqlBuilder);
            return ExecSql(sqlBuilder, exprSql);
        }
        /// <summary>
        /// 根据一个基本的表达式进行删除操作
        /// </summary>
        /// <typeparam name="TEntity">实体对象类型</typeparam>
        /// <param name="whereExpress">表达式</param>
        /// <returns>返回执行结果对象</returns>
        public virtual IExecResult Delete<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new()
        {
            return
            DeleteBase<TEntity>((sqlBuilder) =>
            {
                _ExprAnaly.AnalyWhereExpression<TEntity>(whereExpress, _BuildSql.FormatName, sqlBuilder.AddParam);
                string exprSql = _ExprAnaly.GetValue();
                return exprSql;
            });
        }
        /// <summary>
        /// 使用执行条件对象,进行删除表达式
        /// </summary>
        /// <typeparam name="TEntity">实体对象类型</typeparam>
        /// <param name="execCondition">执行条件对象</param>
        /// <returns>返回执行结果对象</returns>
        public virtual IExecResult Delete<TEntity>(ICondition execCondition) where TEntity : EntityBase, new()
        {
            return
           DeleteBase<TEntity>((sqlBuilder) =>
           {
               string exprSql = WhereJoin<TEntity>(execCondition.WhereResult, sqlBuilder);
               return exprSql;
           });
        }
        /// <summary>
        /// 解析contition中的所有表达式,获取排序sql文本
        /// </summary>
        string GetOrderSQL<TEntity>(IQueryCondition contition) where TEntity : EntityBase, new()
        {
            if (contition == null || contition.OrderByResult == null || contition.OrderByResult.Count == 0) return null;
            StringBuilder orderSql = new StringBuilder();
            foreach (Expression expr in contition.OrderByResult.Keys)
            {
                Expression<Func<TEntity, object>> selector = (Expression<Func<TEntity, object>>)expr;
                _ExprAnaly.AnalySelectorExpression(selector, _BuildSql.FormatName);
                string orderField = _ExprAnaly.GetValue();
                orderSql.AppendFormat("{0} {1},", orderField, contition.OrderByResult[expr]);
            }
            orderSql.Remove(orderSql.Length - 1, 1);
            return orderSql.ToString();
        }
        /// <summary>
        /// 将多个表达式进行合并所有sqlBuilder生成参数,再返回拼接完整的sql文
        /// </summary>
        string WhereJoin<TEntity>(Dictionary<Expression, EmWhereJoin> JoinList, ISqlBuilder sqlBuilder)
        {
            if (JoinList == null) return string.Empty;
            StringBuilder sqlWhere = new StringBuilder();
            bool isFirst = true;
            string analyResutl;
            foreach (Expression expr in JoinList.Keys)
            {
                Expression<Func<TEntity, bool>> ex = (Expression<Func<TEntity, bool>>)expr;
                _ExprAnaly.AnalyWhereExpression<TEntity>(ex, _BuildSql.FormatName, sqlBuilder.AddParam);
                if (!isFirst)
                {
                    sqlWhere.AppendFormat(" {0} ", JoinList[expr].ToString());
                }
                analyResutl = _ExprAnaly.GetValue();
                sqlWhere.Append(analyResutl);
                isFirst = false;
            }
            return sqlWhere.ToString();
        }
        /// <summary>
        /// 根据一个sqlBuilder来构造一个完整的查询
        /// </summary>
        /// <param name="sqlBuilder">可实现参数化查询的sql文本构造器</param>
        public virtual IQueryResult QueryWhere(ISqlBuilder sqlBuilder)
        {
            IQueryResult result = new QueryResult(_DBHelper, sqlBuilder);
            return result;
        }
        /// <summary>
        /// 根据一个sqlBuilder 来构造一个完整的查询，用于获取首行首列值
        /// </summary>
        /// <param name="sqlBuilder">可实现参数化查询的sql文本构造器</param>        
        public virtual IScalarResult QueryWhereScalar(ISqlBuilder sqlBuilder)
        {
            IScalarResult result = new ScalarResult(_DBHelper, sqlBuilder);
            return result;
        }

        /// <summary>
        /// 根据一个sqlBuilder来构造where条件的查询
        /// </summary>
        /// <param name="sqlBuilder">可实现参数化查询的sql文本构造器</param>
        public virtual IQueryResult<TEntity> QueryWhere<TEntity>(ISqlBuilder whereSqlBuilder) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            string[] selectFields = _EntityAnaly.GetAllFields<TEntity>();
            ISqlBuilder sqlBuilder = _BuildSql.BuildQuery(tbName, selectFields);
            if (whereSqlBuilder != null && whereSqlBuilder.SQLText.Length > 2)
            {
                sqlBuilder.AddSQLText(" where ");
                sqlBuilder.AddSQLText(whereSqlBuilder.SQLText);
                sqlBuilder.AppendDbParam(whereSqlBuilder.DbParam);
            }

            IQueryResult<TEntity> result = new QueryResult<TEntity>(_DBHelper, sqlBuilder);
            return result;
        }
        /// <summary>
        /// 使用表达式进行普通查询
        /// </summary>
        /// <typeparam name="TEntity">实体对象类型</typeparam>
        /// <param name="whereExpress">表达式</param>
        public virtual IQueryResult<TEntity> QueryWhere<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            string[] selectFields = _EntityAnaly.GetAllFields<TEntity>();
            ISqlBuilder sqlBuilder = _BuildSql.BuildQuery(tbName, selectFields);
            _ExprAnaly.AnalyWhereExpression<TEntity>(whereExpress, _BuildSql.FormatName, sqlBuilder.AddParam);
            string exprSql = _ExprAnaly.GetValue();
            if (!string.IsNullOrEmpty(exprSql)) sqlBuilder.AddSQLText(" where {0}", exprSql);
            //DbParameter[] dbParam = _DBHelper.ConvertDbParameter(sqlBuilder.DbParam);
            IQueryResult<TEntity> result = new QueryResult<TEntity>(_DBHelper, sqlBuilder);
            return result;
        }
        string JoinSqlBuilder(string exprSql, ISqlBuilder mainSqlBuilder, ISqlBuilder joinSqlBuilder)
        {
            if (joinSqlBuilder != null && joinSqlBuilder.SQLText.Length > 2)
            {
                if (!string.IsNullOrWhiteSpace(exprSql))
                {
                    exprSql = string.Format("{0} and ({1})", exprSql, joinSqlBuilder.SQLText);
                }
                else
                {
                    exprSql = joinSqlBuilder.SQLText;
                }
                mainSqlBuilder.AppendDbParam(joinSqlBuilder.DbParam);
            }
            return exprSql;
        }
        public virtual IQueryResult<TEntity> QueryWhere<TEntity>(IQueryCondition condition) where TEntity : EntityBase, new()
        {
            return QueryWhere<TEntity>(condition, null);
        }
        /// <summary>
        /// 使用条件对象来进行复杂查询
        /// </summary>
        public virtual IQueryResult<TEntity> QueryWhere<TEntity>(IQueryCondition condition, ISqlBuilder joinBuilder) where TEntity : EntityBase, new()
        {
            ISqlBuilder sqlBuilder;
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            string[] selectFields = _EntityAnaly.GetAllFields<TEntity>();
            if (condition != null && condition.PageNo > 0 && condition.OnePage > 0)
            {   //分页                
                sqlBuilder = _BuildSql.BuildQueryPager(tbName, selectFields, condition.PageNo, condition.OnePage);
                string exprSql = WhereJoin<TEntity>(condition.WhereResult, sqlBuilder); //表达式的 where条件
                exprSql = JoinSqlBuilder(exprSql, sqlBuilder, joinBuilder);
                if (string.IsNullOrEmpty(exprSql)) exprSql = "1=1";
                string pagerSql = sqlBuilder.SQLText;
                sqlBuilder.ClearSQL();
                string orderSql = GetOrderSQL<TEntity>(condition);
                sqlBuilder.AddSQLText(pagerSql, exprSql, orderSql);
                //查询分页前的数量
                ISqlBuilder sqlCountBuilder = _BuildSql.BuildCountFunction(tbName);
                exprSql = WhereJoin<TEntity>(condition.WhereResult, sqlCountBuilder); //表达式的 where条件
                exprSql = JoinSqlBuilder(exprSql, sqlCountBuilder, joinBuilder);
                if (!string.IsNullOrEmpty(exprSql))
                {
                    sqlCountBuilder.AddSQLText(" where ");
                    sqlCountBuilder.AddSQLText(exprSql);
                }
                IScalarResult scalarResult = new ScalarResult(_DBHelper, sqlCountBuilder);
                ((QueryCondition)condition).RecordCount = scalarResult.ToObject<int>();
            }
            else
            {   //非分页
                sqlBuilder = _BuildSql.BuildQuery(tbName, selectFields);
                string exprSql = WhereJoin<TEntity>(condition.WhereResult, sqlBuilder);
                exprSql = JoinSqlBuilder(exprSql, sqlBuilder, joinBuilder);
                if (!string.IsNullOrEmpty(exprSql))
                {
                    sqlBuilder.AddSQLText(" where ");
                    sqlBuilder.AddSQLText(exprSql);
                }
                string orderSql = GetOrderSQL<TEntity>(condition);
                if (!string.IsNullOrEmpty(orderSql))
                {
                    sqlBuilder.AddSQLText(" Order By {0}", orderSql);
                }
            }
            var result = new QueryResult<TEntity>(_DBHelper, sqlBuilder);
            result.TableName = tbName;
            return result;
        }
        //public virtual IQueryResult<TEntity> QueryPageData<TEntity>(int onePage, int pageNo, out int recordCount, Action<IQueryCondition<TEntity>> queryAction) where TEntity : EntityBase, new()
        //{
        //    var query = CreateQueryCondition<TEntity>();
        //    query.OnePage = onePage;
        //    query.PageNo = pageNo;
        //    if (queryAction != null)
        //    {
        //        queryAction(query);
        //    }

        //    var result = QueryWhere<TEntity>(query);
        //TODO 如果分页查询实现，则需要指定返回list或者DataTable，执行查询之前还未知记录数，所以不能计算
        //    if (query.OnePage == 0 || query.PageNo == 0)
        //    {
        //        recordCount = result.Count;
        //    }
        //    else
        //    {
        //        recordCount = query.RecordCount;
        //    }
        //    return result;
        //}
        
        /// <summary>
        /// 查询首行首列的基本方法,其它方法共通,(使用自定义的sql建造方法:GetExprSql)
        /// </summary>
        IScalarResult QueryFunction<TEntity>(Expression<Func<TEntity, object>> selector, Func<ISqlBuilder, string> GetExprSql, Func<string, string, ISqlBuilder> BuildFunction) where TEntity : EntityBase, new()
        {
            string tbName = _EntityAnaly.GetTableName<TEntity>();
            _ExprAnaly.AnalySelectorExpression(selector, _BuildSql.FormatName);
            string fieldName = _ExprAnaly.GetValue();
            ISqlBuilder sqlBuilder = BuildFunction(tbName, fieldName);
            string exprSql = GetExprSql(sqlBuilder);
            if (!string.IsNullOrEmpty(exprSql))
            {
                sqlBuilder.AddSQLText(" where {0}", exprSql);
            }
            ScalarResult result = new ScalarResult(_DBHelper, sqlBuilder);
            return result;
        }
        /// <summary>
        /// 查询首行首列的基本方法,其它方法共通,(将 condition合并生成sql文本和参数)
        /// </summary>
        IScalarResult QueryFunction<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition, Func<string, string, ISqlBuilder> BuildFunction) where TEntity : EntityBase, new()
        {
            return
            QueryFunction<TEntity>(selector, (sqlBuilder) =>
            {
                string exprSql = WhereJoin<TEntity>(condition.WhereResult, sqlBuilder);
                return exprSql;

            }, BuildFunction);
        }
        /// <summary>
        /// 查询首行首列的基本方法,其它方法共通,(解析表达式sql文本和参数)
        /// </summary>
        IScalarResult QueryFunction<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr, Func<string, string, ISqlBuilder> BuildFunction) where TEntity : EntityBase, new()
        {
            return
            QueryFunction<TEntity>(selector, (sqlBuilder) =>
            {
                _ExprAnaly.AnalyWhereExpression(whereExpr, _BuildSql.FormatName, sqlBuilder.AddParam);
                string exprSql = _ExprAnaly.GetValue();
                return exprSql;

            }, BuildFunction);
        }
        /// <summary>
        /// 执行最大值函数查询
        /// </summary>
        public virtual IScalarResult QueryMax<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new()
        {
            return QueryFunction(selector, whereExpr, _BuildSql.BuildMaxFunction);
        }
        public virtual IScalarResult QueryMax<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition) where TEntity : EntityBase, new()
        {
            return QueryFunction(selector, condition, _BuildSql.BuildMaxFunction);
        }
        public virtual IScalarResult QueryMin<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new()
        {
            return QueryFunction(selector, whereExpr, _BuildSql.BuildMinFunction);
        }
        public virtual IScalarResult QueryMin<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition) where TEntity : EntityBase, new()
        {
            return QueryFunction(selector, condition, _BuildSql.BuildMinFunction);
        }
        public virtual IScalarResult QuerySum<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new()
        {
            return QueryFunction(selector, whereExpr, _BuildSql.BuildSumFunction);
        }
        public virtual IScalarResult QuerySum<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition) where TEntity : EntityBase, new()
        {
            return QueryFunction(selector, condition, _BuildSql.BuildSumFunction);
        }
        public virtual IScalarResult QueryCount<TEntity>(Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new()
        {
            return
            QueryFunction<TEntity>(null, whereExpr, (tbName, fields) =>
            {
                ISqlBuilder sqlBuilder = _BuildSql.BuildCountFunction(tbName);
                return sqlBuilder;
            });
        }
        public virtual IScalarResult QueryCount<TEntity>(ICondition condition) where TEntity : EntityBase, new()
        {
            return
            QueryFunction<TEntity>(null, condition, (tbName, fields) =>
            {
                ISqlBuilder sqlBuilder = _BuildSql.BuildCountFunction(tbName);
                return sqlBuilder;
            });
        }
        public virtual bool QueryExist<TEntity>(ICondition condition) where TEntity : EntityBase, new()
        {
            var r = QueryCount<TEntity>(condition);
            var count = r.ToObject<int>();
            return count > 0;
        }
        public virtual bool QueryExist<TEntity>(Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new()
        {
            var r = QueryCount<TEntity>(whereExpr);
            var count = r.ToObject<int>();
            return count > 0;
        }

        public IProcResult ExecProcedure<ProcEntity>(ProcEntity procObj) where ProcEntity : ProcedureEntiryBase, new()
        {
            IProcResult r = new IProcResult(_DBHelper, procObj);
            return r;
        }

        #region 存储过程运行正常可删除，不正常进行比较
        
        //public int ExecProcedure<ProcEntity>(ProcEntity procObj) where ProcEntity : ProcedureEntiryBase, new()
        //{
        //    string procName = procObj.GetProcedureName();
        //    var procParams = procObj.GetProcParamObj(_DBHelper.CreateDbParameter);
        //    int r = DbHelper.ExecNonQuery(procName, CommandType.StoredProcedure, procParams);
        //    procObj.SetOutParamValue(procParams);
        //    return r;
        //}
        //public DataTable ExecProcedureGetDataTable<ProcEntity>(ProcEntity procObj) where ProcEntity : ProcedureEntiryBase, new()
        //{
        //    string procName = procObj.GetProcedureName();
        //    var procParams = procObj.GetProcParamObj(_DBHelper.CreateDbParameter);
        //    var r = DbHelper.GetDataTable(procName,CommandType.StoredProcedure, procParams);
        //    procObj.SetOutParamValue(procParams);
        //    return r;
        //}

        #endregion
    }
}