using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace ZhCun.Framework.BuildSQLText
{
    #region 用于Lambda表达式的扩展方法(用于解析表达式)

    /// <summary>
    /// where查询的扩展方法定义
    /// </summary>
    public static class WhereExFun
    {
        public static bool In<T>(this T obj, T[] array)
        {
            return true;
        }
        public static bool NotIn<T>(this T obj, T[] array)
        {
            return true;
        }
        /// <summary>
        /// like查询,需指定左右模糊(%查询值%)
        /// </summary>
        public static bool Like(this string str, string likeStr)
        {
            return true;
        }
        /// <summary>
        /// NotLike查询,需指定左右模糊(%查询值%)
        /// </summary>
        public static bool NotLike(this string str, string likeStr)
        {
            return true;
        }
    }

    #endregion

    /// <summary>
    /// 解析Lambda表达式的where解析类
    /// </summary>
    public class AnalyExpression
    {
        public AnalyExpression()
        { }

        public static string AnalySelectorExpression<TEntity, TResult>(Expression<Func<TEntity, TResult>> selector)
        {
            if (selector == null) return null;
            BinaryExpression be = ((BinaryExpression)selector.Body);
            MemberExpression me = ((MemberExpression)be.Left);
            return me.Member.Name;
        }
        /// <summary>
        /// 格式话参数名的委托的方法
        /// </summary>
        Func<string, string> FormatFieldNameFun;
        /// <summary>
        /// 增加参数的委托方法
        /// </summary>
        Func<object, string> AddParamValueFun;
        /// <summary>
        /// 解析表达式
        /// </summary>
        public string AnalyWhereExpression<T>(Expression<Func<T, bool>> whereExpr, Func<string, string> formatFieldNameFun, Func<object, string> addParamValueFun)
        {
            if (whereExpr == null || formatFieldNameFun == null || addParamValueFun == null) return null;
            FormatFieldNameFun = formatFieldNameFun;
            AddParamValueFun = addParamValueFun;

            string r = string.Empty;
            if (whereExpr.Body is BinaryExpression)
            {
                BinaryExpression be = ((BinaryExpression)whereExpr.Body);
                r = BinarExpressionProvider(be.Left, be.Right, be.NodeType);
            }
            else
            {
                r = ExpressionRouter(whereExpr.Body);
            }
            return r;
        }
        /// <summary>
        /// 解析二元表达式
        /// </summary>
        public string BinarExpressionProvider(Expression left, Expression right, ExpressionType type)
        {
            string sb = "(";
            //先处理左边
            sb += ExpressionRouter(left);
            //处理连接符
            sb += ExpressionTypeCast(type);
            //再处理右边
            string tmpStr = ExpressionRouter(right);
            if (tmpStr == "null")
            {
                if (sb.EndsWith(" ="))
                    sb = sb.Substring(0, sb.Length - 2) + " is null";
                else if (sb.EndsWith("<>"))
                    sb = sb.Substring(0, sb.Length - 2) + " is not null";
            }
            else
                sb += tmpStr;
            return sb += ")";
        }
        /// <summary>
        /// 解析表达式得到返回结果字符
        /// </summary>
        public string ExpressionRouter(Expression exp)
        {
            string sb = string.Empty;
            if (exp is BinaryExpression)
            {
                //二元表达式
                BinaryExpression be = ((BinaryExpression)exp);
                return BinarExpressionProvider(be.Left, be.Right, be.NodeType);
            }
            else if (exp is MemberExpression)
            {
                //得到表达式(Left)的字段或属性名字
                MemberExpression me = ((MemberExpression)exp);
                
                if (me.Expression is ConstantExpression)
                {
                   // System.Linq.Expressions.PropertyExpression aa = null;

                    //System.Linq.Expressions.TypedParameterExpression

                    ConstantExpression ce = (ConstantExpression)me.Expression;
                    if (ce.Value == null) return "null"; //null字符串会判断 is null
                    System.Reflection.FieldInfo fieldInfo = ce.Value.GetType().GetField(me.Member.Name);
                    object obj = fieldInfo.GetValue(ce.Value);
                    //object obj = Convert.ChangeType(ce.Value, me.Type);
                    string paramName = AddParamValueFun(obj);
                    return paramName;
                }
                else
                {
                    return FormatFieldNameFun(me.Member.Name);
                }
            }
            else if (exp is NewArrayExpression)
            {
                //数组表达式
                NewArrayExpression ae = ((NewArrayExpression)exp);
                StringBuilder tmpstr = new StringBuilder();
                foreach (Expression ex in ae.Expressions)
                {
                    tmpstr.Append(ExpressionRouter(ex));
                    tmpstr.Append(",");
                }
                return tmpstr.ToString(0, tmpstr.Length - 1);
            }
            else if (exp is MethodCallExpression)
            {
                //方法表达式,这里全部为自定义
                MethodCallExpression mce = (MethodCallExpression)exp;
                string fieldName = FormatFieldNameFun(ExpressionRouter(mce.Arguments[0]));
                string paramName = ExpressionRouter(mce.Arguments[1]);
                if (mce.Method.Name == "Like")
                {
                    return string.Format("({0} like {1})", fieldName, paramName);
                }
                else if (mce.Method.Name == "NotLike")
                {
                    return string.Format("({0} Not like {1})", fieldName, paramName);
                }
                else if (mce.Method.Name == "In")
                {
                    return string.Format("{0} In ({1})", fieldName, ExpressionRouter(mce.Arguments[1]));
                }
                else if (mce.Method.Name == "NotIn")
                {
                    return string.Format("{0} Not In ({1})", fieldName, ExpressionRouter(mce.Arguments[1]));
                }
                else
                {
                    throw new Exception(string.Format("未实现处理 MethodCallExpression表达式 [{0}]方法的实现", mce.Method.Name));
                }
            }
            else if (exp is ConstantExpression)
            {
                //二元表达式的右边
                ConstantExpression ce = ((ConstantExpression)exp);
                if (ce.Value == null) return "null"; //null字符串会判断 is null
                
                string paramName = AddParamValueFun(ce.Value);
                return paramName;
            }
            else if (exp is UnaryExpression)
            {
                UnaryExpression ue = ((UnaryExpression)exp);
                return ExpressionRouter(ue.Operand);
            }
            else
            {
                throw new Exception(string.Format("未实现处理{0}表达式的方法", exp.GetType().ToString()));
            }
        }
        /// <summary>
        /// 二元表达式中的中间连接符类型映射
        /// </summary>
        string ExpressionTypeCast(ExpressionType type)
        {
            switch (type)
            {
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                    return " AND ";
                case ExpressionType.Equal:
                    return " =";
                case ExpressionType.GreaterThan:
                    return " >";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                case ExpressionType.NotEqual:
                    return "<>";
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                    return " Or ";
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                    return "+";
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                    return "-";
                case ExpressionType.Divide:
                    return "/";
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                    return "*";
                default:
                    throw new Exception(string.Format("未实现处理 ExpressionType 的实现,{0}", type.GetType().ToString()));
            }
        }
    }
}