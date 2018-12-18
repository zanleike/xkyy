using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Framework.Core
{    
    public interface ICondition
    {
        /// <summary>
        /// where条件集合列表
        /// </summary>
        Dictionary<Expression, EmWhereJoin> WhereResult { get; }
        /// <summary>
        /// 清楚当前条件内所有内容,来用于对象的复用
        /// </summary>
        void ClearExpression();
        /// <summary>
        /// 使用and拼接一条表达式
        /// </summary>
        ICondition WhereAnd<TEntity>(Expression<Func<TEntity, bool>> whereExpress);
        /// <summary>
        /// 使用or拼接一条表达式
        /// </summary>
        ICondition WhereOr<TEntity>(Expression<Func<TEntity, bool>> whereExpress);        
    }

    public interface ICondition<TEntity> : ICondition
    {
        ICondition<TEntity> WhereAnd(Expression<Func<TEntity, bool>> whereExpress);
        ICondition<TEntity> WhereOr(Expression<Func<TEntity, bool>> whereExpress);
    }

    public interface IQueryCondition : ICondition
    {
        Dictionary<Expression, EmOrderByType> OrderByResult { get; }
        /// <summary>
        /// 分页时使用的当前页码(为0不分页)
        /// </summary>
        int PageNo { set; get; }
        /// <summary>
        /// 每页显示的记录数(为0不分页)
        /// </summary>
        int OnePage { set; get; }
        /// <summary>
        /// 用于输出的页数
        /// </summary>
        int PageCount { get; }
        /// <summary>
        /// 用于输出分页前的记录数
        /// </summary>
        int RecordCount { get; }
        new IQueryCondition WhereAnd<TEntity>(Expression<Func<TEntity, bool>> whereExpress);
        new IQueryCondition WhereOr<TEntity>(Expression<Func<TEntity, bool>> whereExpress);
        /// <summary>
        /// 指定字段进行默认升序排序
        /// </summary>
        IQueryCondition OrderBy<TEntity>(Expression<Func<TEntity, object>> selector);
        /// <summary>
        /// 指定字段进行排序,由orderType来指定升序还是降序
        /// </summary>
        IQueryCondition OrderBy<TEntity>(Expression<Func<TEntity, object>> selector, EmOrderByType orderType);
    }

    public interface IQueryCondition<TEntity> : IQueryCondition
    {
        IQueryCondition<TEntity> WhereAnd(Expression<Func<TEntity, bool>> whereExpress);
        IQueryCondition<TEntity> WhereOr(Expression<Func<TEntity, bool>> whereExpress);
        IQueryCondition<TEntity> OrderBy(Expression<Func<TEntity, object>> selector);
        IQueryCondition<TEntity> OrderBy(Expression<Func<TEntity, object>> selector, EmOrderByType orderType);
    }

    class ExecCondition : ICondition
    {
        protected Dictionary<Expression, EmWhereJoin> _WhereResult;

        public Dictionary<Expression, EmWhereJoin> WhereResult
        {
            get { return _WhereResult; }
        }

        void WhereJoin<TEntity>(Expression<Func<TEntity, bool>> whereExpress, EmWhereJoin jsonType)
        {
            if (_WhereResult == null)
            {
                _WhereResult = new Dictionary<Expression, EmWhereJoin>();
            }
            _WhereResult.Add(whereExpress, jsonType);
        }

        public ICondition WhereAnd<TEntity>(Expression<Func<TEntity, bool>> whereExpress)
        {
            WhereJoin(whereExpress, EmWhereJoin.And);
            return this;
        }
        public ICondition WhereOr<TEntity>(Expression<Func<TEntity, bool>> whereExpress)
        {
            WhereJoin(whereExpress, EmWhereJoin.Or);
            return this;
        }
        public void ClearExpression()
        {
            _WhereResult = null;
        }
    }

    class ExecCondition<TEntity> : ExecCondition, ICondition<TEntity>
    {
        public ICondition<TEntity> WhereAnd(Expression<Func<TEntity, bool>> whereExpress)
        {
             base.WhereAnd(whereExpress);
             return this;
        }

        public ICondition<TEntity> WhereOr(Expression<Func<TEntity, bool>> whereExpress)
        {
            base.WhereOr(whereExpress);
            return this;
        }
    }

    class QueryCondition : ExecCondition, IQueryCondition
    {
        Dictionary<Expression, EmOrderByType> _OrderByResult;
        public Dictionary<Expression, EmOrderByType> OrderByResult
        {
            get { return _OrderByResult; }
        }
        public int PageNo { set; get; }
        public int OnePage { set; get; }

        public int RecordCount { protected internal set; get; }
        public int PageCount
        {
            get
            {
                if (PageNo > 0 && OnePage > 0)
                {
                    int pageCount = RecordCount / OnePage;
                    if (RecordCount % OnePage != 0)
                    {
                        pageCount++;
                    }
                    return pageCount;
                }
                return 0;
            }
        }

        public new IQueryCondition WhereAnd<TEntity>(Expression<Func<TEntity, bool>> whereExpress)
        {
            base.WhereAnd(whereExpress);
            return this;
        }
        public new IQueryCondition WhereOr<TEntity>(Expression<Func<TEntity, bool>> whereExpress)
        {
            base.WhereAnd(whereExpress);
            return this;
        }
        public IQueryCondition OrderBy<TEntity>(Expression<Func<TEntity, object>> selector, EmOrderByType orderType)
        {
            if (_OrderByResult == null) _OrderByResult = new Dictionary<Expression, EmOrderByType>();
            _OrderByResult.Add(selector, orderType);
            return this;
        }
        public IQueryCondition OrderBy<TEntity>(Expression<Func<TEntity, object>> selector)
        {
            OrderBy<TEntity>(selector, EmOrderByType.Asc);
            return this;
        }

        public new void ClearExpression()
        {
            base.ClearExpression();
            if (_OrderByResult != null)
            {
                _OrderByResult.Clear();
            }
        }
    }

    class QueryCondition<TEntity> : QueryCondition, IQueryCondition<TEntity>
    {
        public IQueryCondition<TEntity> WhereAnd(Expression<Func<TEntity, bool>> whereExpress)
        {
            base.WhereAnd<TEntity>(whereExpress);
            return this;
        }

        public IQueryCondition<TEntity> WhereOr(Expression<Func<TEntity, bool>> whereExpress)
        {
            base.WhereOr<TEntity>(whereExpress);
            return this;
        }

        public IQueryCondition<TEntity> OrderBy(Expression<Func<TEntity, object>> selector, EmOrderByType orderType)
        {
            base.OrderBy<TEntity>(selector, orderType);
            return this;
        }
        public IQueryCondition<TEntity> OrderBy(Expression<Func<TEntity, object>> selector)
        {
            base.OrderBy<TEntity>(selector);
            return this;
        }
    }
}
