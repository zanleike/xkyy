using System;
using Framework.BuildSQLText;
using Framework.Entitys;
using System.Linq.Expressions;
using System.Data;
namespace Framework.Core
{
    public interface IDBContext
    {
        /// <summary>
        /// 创建一个执行条件对象
        /// </summary>
        ICondition CreateExecCondition();
        /// <summary>
        /// 创建一个执行语句的条件对象(泛型)
        /// </summary>
        ICondition<TEntity> CreateExecCondition<TEntity>() where TEntity : EntityBase, new();
        /// <summary>
        /// 创建一个查询条件对象
        /// </summary>
        IQueryCondition CreateQueryCondition();
        /// <summary>
        /// 创建一个查询条件对象(泛型)
        /// </summary>
        IQueryCondition<TEntity> CreateQueryCondition<TEntity>() where TEntity : EntityBase, new();
        /// <summary>
        /// 创建一个sql构建器,用来拼接sql语句
        /// </summary>
        ISqlBuilder CreateSqlBuilder();
        /// <summary>
        /// 创建一个sql构建器,用来拼接sql语句
        /// </summary>
        ISqlBuilder CreateSqlBuilder(string paramKey);
        /// <summary>
        /// 在当前一个数据库操作(IDBContext)开启事务
        /// </summary>
        void TransStart();
        /// <summary>
        /// 提交当前事务
        /// </summary>
        void TransCommit();
        /// <summary>
        /// 事务回滚
        /// </summary>
        void TransRollback();
        /// <summary>
        /// 通过sql构建对象来执行一个条sql语句
        /// </summary>
        IExecResult ExecSql(ISqlBuilder sqlBuilder);
        /// <summary>
        /// 新增一条记录
        /// </summary>
        IExecResult Insert<TEntity>(TEntity entity) where TEntity : EntityBase, new();
        /// <summary>
        /// 根据主键更新记录
        /// </summary>
        IExecResult Update<TEntity>(TEntity entity) where TEntity : EntityBase, new();
        /// <summary>
        /// 根据一个lambda表达式来更新多条记录
        /// </summary>
        IExecResult Update<TEntity>(TEntity entity, Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new();
        /// <summary>
        /// 根据条件对象来更新多条记录
        /// </summary>
        IExecResult Update<TEntity>(TEntity entity, ICondition execCondition) where TEntity : EntityBase, new();
        /// <summary>
        /// 根据主键来删除一条记录
        /// </summary>
        IExecResult Delete<TEntity>(TEntity entity) where TEntity : EntityBase, new();
        /// <summary>
        /// 根据一个lambda表达式来删除多条记录
        /// </summary>
        IExecResult Delete<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new();
        /// <summary>
        /// 根据条件对象来删除多条记录
        /// </summary>
        IExecResult Delete<TEntity>(ICondition execCondition) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用一个sql构建器,来查询记录,记录只能返回DataTable
        /// </summary>
        IQueryResult QueryWhere(ISqlBuilder sqlBuilder);
         /// <summary>
        /// 根据一个sqlBuilder 来构造一个完整的查询，用于获取首行首列值
        /// </summary>
        /// <param name="sqlBuilder">可实现参数化查询的sql文本构造器</param>        
        IScalarResult QueryWhereScalar(ISqlBuilder sqlBuilder);        
        /// <summary>
        /// 使用一个sql构建器,来查询记录,指定实体类型,可构建强类型对象(List)
        /// </summary>
        IQueryResult<TEntity> QueryWhere<TEntity>(ISqlBuilder sqlBuilder) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用lambda表达式来查询记录,仅限于where条件
        /// </summary>
        IQueryResult<TEntity> QueryWhere<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用查询条件对象来查询记录,包含分页与排序,分页后由contition对象返回记录数与页数
        /// </summary>
        IQueryResult<TEntity> QueryWhere<TEntity>(IQueryCondition contition) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用查询条件对象来查询记录,包含分页与排序,分页后由contition对象返回记录数与页数,可合并一个sqlBuilder
        /// </summary>
        IQueryResult<TEntity> QueryWhere<TEntity>(IQueryCondition condition, ISqlBuilder joinBuilder) where TEntity : EntityBase, new();
        /// <summary>
        /// 查询指定条件记录数
        /// </summary>
        IScalarResult QueryCount<TEntity>(Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用条件对象查询指定条件记录数,
        /// </summary>
        IScalarResult QueryCount<TEntity>(ICondition condition) where TEntity : EntityBase, new();
        /// <summary>
        /// 查询指定最大值,selector为查询字段
        /// </summary>
        IScalarResult QueryMax<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用条件对象来查询指定字段的最大值
        /// </summary>
        IScalarResult QueryMax<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用lambda查询指定字段最大值
        /// </summary>
        IScalarResult QueryMin<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用条件对象查询指定字段最大值
        /// </summary>
        IScalarResult QueryMin<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用lambda表达式统计指定字段总和
        /// </summary>
        IScalarResult QuerySum<TEntity>(Expression<Func<TEntity, object>> selector, Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用执行对象统计指定字段总和
        /// </summary>
        IScalarResult QuerySum<TEntity>(Expression<Func<TEntity, object>> selector, ICondition condition) where TEntity : EntityBase, new();
        /// <summary>
        /// 使用lambda表达式查询记录是否存在
        /// </summary>
        bool QueryExist<TEntity>(ICondition condition) where TEntity : EntityBase, new();
        /// <summary>        
        /// 指定条件对象查询记录是否存在
        /// </summary>
        bool QueryExist<TEntity>(Expression<Func<TEntity, bool>> whereExpr) where TEntity : EntityBase, new();

        #region 存储过程运行正常则可删除，不正常需比较

        ///// <summary>
        ///// 执行存储过程返回所影响行数
        ///// </summary>
        //int ExecProcedure<ProcEntity>(ProcEntity procObj) where ProcEntity : ProcedureEntiryBase, new();
        ///// <summary>
        ///// 执行存储过程返回DataTable
        ///// </summary>
        //DataTable ExecProcedureGetDataTable<ProcEntity>(ProcEntity procObj) where ProcEntity : ProcedureEntiryBase, new();

        #endregion

        /// <summary>
        /// 执行存储过程返回存储过程对象
        /// </summary>
        /// <typeparam name="ProcEntity"></typeparam>
        /// <param name="procObj"></param>
        /// <returns></returns>
        IProcResult ExecProcedure<ProcEntity>(ProcEntity procObj) where ProcEntity : ProcedureEntiryBase, new();
    }
}