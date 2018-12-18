using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Framework.Entitys;

namespace Framework.Core
{
    public interface IDBContext<TEntity> where TEntity : EntityBase, new()
    {
        IExecResult Insert(TEntity entity);

        IExecResult Update(TEntity entity);

        IExecResult Update(Expression<Func<TEntity, bool>> whereExpress);

        IExecResult Delete(TEntity entity);

        IExecResult Delete(Expression<Func<TEntity, bool>> whereExpress);

        IQueryResult<TEntity> QueryWhere(Expression<Func<TEntity, bool>> whereExpress);

        TResult QueryMax<TResult>(Expression<Func<TEntity, TResult>> selector);  //如果使用泛型方法,改方式使用起来必须指定TResult的类型,使用不方便

        TResult QueryMin<TResult>(Expression<Func<TEntity, TResult>> selector);

        TResult QueryCount<TResult>(Expression<Func<TEntity, TResult>> selector);
    }
}
