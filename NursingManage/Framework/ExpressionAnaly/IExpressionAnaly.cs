using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Framework.Entitys;

namespace Framework.ExpressionAnaly
{
    public interface IExpressionAnaly
    {
        void AnalyWhereExpression<T>(Expression<Func<T, bool>> whereExpr, Func<string, string> formatFieldNameFun, Func<object, string> addParamValueFun);
        void AnalySelectorExpression<TEntity>(Expression<Func<TEntity, object>> selector, Func<string, string> formatFieldNameFun);
        string GetValue();
    }
}
