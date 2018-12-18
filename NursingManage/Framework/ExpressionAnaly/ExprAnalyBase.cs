/*
创建日期: 2015.8.18
    创建者:张存
    邮箱:zhangcunliang@126.com
    说明:
        解析表达式解析对象
    修改记录: 
        2015.11.8   1.增加扩展方法 WEx_GreaterThenEqual,WEx_LessThan,WEx_LessThan,WEx_LessThanEqual
                      实现字符串>=,>,<=,<的表达式解析
                    
                    2.解析第一个表达式为"方法"时(非二元表达式)不解析的bug
        2016.4.29   处理In或InNot时,如果传入参数为数组对象时不会出成 NewArrayExpression ,将动态生成IList对象
        2016.6.20   In或InNot处理时,将数组转为Array对象(之前为IList,IList转换非string[]会转换失败)
        2016.6.29   查询时字段值不再仅限于支持对象属性,开始支持变量及常量
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;

namespace Framework.ExpressionAnaly
{
    public class ExprAnalyBase : IExpressionAnaly
    {
        public ExprAnalyBase()
        {
            SqlWhere = new StringBuilder();
            AnalyList = new List<Func<Expression, bool>>();
            AnalyList.Add(AlanyBinary);
            AnalyList.Add(AlanyConstant);
            AnalyList.Add(AlanyMethod);
            AnalyList.Add(AlanyNewArray);
            AnalyList.Add(AlanyMemberRight); //这个必须放到最后,因为它始终返回true
        }
        StringBuilder SqlWhere;
        List<Func<Expression, bool>> AnalyList;
        /// <summary>
        /// 格式话参数名的委托的方法
        /// </summary>
        Func<string, string> FormatFieldNameFun;
        /// <summary>
        /// 增加参数的委托方法
        /// </summary>
        Func<object, string> AddParamValueFun;
        /// <summary>
        /// 二元表达式分解
        /// </summary>
        void AlanyBinarExpression(Expression left, Expression right, ExpressionType type)
        {
            SqlWhere.Append("(");
            AlanyLeft(left);
            AlanyExpressionType(type);
            ExpressionRouter(right);
            SqlWhere.Append(")");
        }
        /// <summary>
        /// 二元表达式中的中间连接符类型映射
        /// </summary>
        void AlanyExpressionType(ExpressionType type)
        {
            string typeStr = string.Empty;
            switch (type)
            {
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                    typeStr = " AND ";
                    break;
                case ExpressionType.Equal:
                    typeStr = " =";
                    break;
                case ExpressionType.GreaterThan:
                    typeStr = " >";
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    typeStr = ">=";
                    break;
                case ExpressionType.LessThan:
                    typeStr = "<";
                    break;
                case ExpressionType.LessThanOrEqual:
                    typeStr = "<=";
                    break;
                case ExpressionType.NotEqual:
                    typeStr = "<>";
                    break;
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                    typeStr = " Or ";
                    break;
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                    typeStr = "+";
                    break;
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                    typeStr = "-";
                    break;
                case ExpressionType.Divide:
                    typeStr = "/";
                    break;
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                    typeStr = "*";
                    break;
                default:
                    throw new Exception(string.Format("未实现处理 ExpressionType 的实现,{0}", type.GetType().ToString()));
            }
            SqlWhere.Append(typeStr);
        }
        /// <summary>
        /// 解析二元表达式
        /// </summary>
        bool AlanyBinary(Expression exp)
        {
            if (exp is BinaryExpression)
            {
                BinaryExpression be = ((BinaryExpression)exp);
                AlanyBinarExpression(be.Left, be.Right, be.NodeType);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 解析字段或属表达式,左部分(字段名称)
        /// 左边只有3可能,1是二元表达式,2属性,3方法
        /// </summary>
        bool AlanyLeft(Expression exp)
        {
            if (exp is ConstantExpression)
            {
                ConstantExpression ce = ((ConstantExpression)exp);
                object obj = ce.Value;
                string fieldName = FormatFieldNameFun(obj.ToString());
                SqlWhere.Append(fieldName);
            }
            else if (exp is MemberExpression)
            {
                MemberExpression me = (MemberExpression)exp;
                string searchField = null;
                if (me.Member.MemberType.ToString() == "Field")
                {
                    var searchFieldObj = Expression.Lambda(me).Compile().DynamicInvoke();
                    if (searchFieldObj != null)
                    {
                        searchField = searchFieldObj.ToString();
                    }
                }
                else
                {
                    searchField = me.Member.Name;
                }
                string fieldName = FormatFieldNameFun(searchField);
                SqlWhere.Append(fieldName);
                return true;
            }
            else if (exp is BinaryExpression)
            {
                AlanyBinary(exp);
            }
            else if (exp is MethodCallExpression)
            {
                AlanyMethod(exp);
            }
            return false;
        }
        /// <summary>
        /// 解析字段或属表达式,右部分(值)
        /// </summary>
        bool AlanyMemberRight(Expression exp)
        {
            object obj = Expression.Lambda(exp).Compile().DynamicInvoke();
            if (obj == null)
            {
                SqlWhere.Replace("!=", " is not null ", SqlWhere.Length - 2, 2);
                SqlWhere.Replace("<>", " is not null ", SqlWhere.Length - 2, 2);
                SqlWhere.Replace("=", " is null ", SqlWhere.Length - 1, 1);
            }
            else
            {
                string paramName = AddParamValueFun(obj);
                SqlWhere.Append(paramName);
            }
            return obj != null;
        }
        /// <summary>
        /// 解析常量,右部分
        /// </summary>
        bool AlanyConstant(Expression exp)
        {
            if (exp is ConstantExpression)
            {
                //二元表达式的右边
                ConstantExpression ce = ((ConstantExpression)exp);
                object obj = ce.Value;
                if (obj == null)
                {
                    SqlWhere.Replace("!=", " is not null ", SqlWhere.Length - 2, 2);
                    SqlWhere.Replace("<>", " is not null ", SqlWhere.Length - 2, 2);
                    SqlWhere.Replace("=", " is null ", SqlWhere.Length - 1, 1);
                }
                else
                {
                    string paramName = AddParamValueFun(obj);
                    SqlWhere.Append(paramName);
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// 解析一元表达式
        /// </summary>
        bool AlanyUnary(Expression exp)
        {
            if (exp is UnaryExpression)
            {
                UnaryExpression ue = ((UnaryExpression)exp);
                SqlWhere.Append("1=1");
                return true;
            }
            return false;
        }
        /// <summary>
        /// 解析数组表达式
        /// </summary>
        bool AlanyNewArray(Expression exp)
        {
            if (exp is NewArrayExpression)
            {
                //数组表达式
                NewArrayExpression ae = ((NewArrayExpression)exp);
                foreach (Expression ex in ae.Expressions)
                {
                    ExpressionRouter(ex);
                    SqlWhere.Append(",");
                }
                SqlWhere.Remove(SqlWhere.Length - 1, 1);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 增加扩展方法中第一个参数(即字段名)的解析并赋值
        /// </summary>
        /// <param name="exp"></param>
        void AddExMethodFieldName(MethodCallExpression mce)
        {
            if (mce.Arguments[0] is ConstantExpression)
            {
                ConstantExpression ce = ((ConstantExpression)mce.Arguments[0]);
                object obj = ce.Value;
                SqlWhere.Append(string.Format(" {0} ", obj.ToString()));
            }
            else if (mce.Arguments[0] is MemberExpression &&
                ((MemberExpression)mce.Arguments[0]).Member.DeclaringType.BaseType == typeof(Framework.Entitys.EntityBase))
            {
                MemberExpression me = (MemberExpression)mce.Arguments[0];
                string fieldName = FormatFieldNameFun(me.Member.Name);
                SqlWhere.Append(fieldName);

                //如果方法中使用成员

            }
            else
            {
                object obj = Expression.Lambda(mce.Arguments[0]).Compile().DynamicInvoke();
                string fieldName = FormatFieldNameFun(obj.ToString());
                SqlWhere.Append(fieldName);
            }
        }
        /// <summary>
        /// 解析数组表达式,或为NewArray表达式,或为Array对象,(用于In或NotIn的解析)
        /// </summary>
        /// <param name="exp"></param>
        void AlanyArrayObj(Expression exp)
        {
            if (!AlanyNewArray(exp))
            {
                var arrObj = Expression.Lambda(exp).Compile().DynamicInvoke();
                var arrList = arrObj as Array;
                foreach (var item in arrList)
                {
                    string fieldName = AddParamValueFun(item);
                    SqlWhere.Append(fieldName).Append(",");
                }
                SqlWhere.Remove(SqlWhere.Length - 1, 1);
            }
        }
        /// <summary>
        /// 解析方法表达式
        /// </summary>
        bool AlanyMethod(Expression exp)
        {
            if (exp is MethodCallExpression)
            {
                MethodCallExpression mce = (MethodCallExpression)exp;
                if (mce.Method.Name == "WEx_Like")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" like ");
                    ExpressionRouter(mce.Arguments[1]);
                }
                else if (mce.Method.Name == "WEx_LikeNot")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" Not Like ");
                    ExpressionRouter(mce.Arguments[1]); //字符串
                }
                else if (mce.Method.Name == "WEx_In")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" In (");
                    //ExpressionRouter(mce.Arguments[1]);
                    AlanyArrayObj(mce.Arguments[1]);
                    SqlWhere.Append(")");
                }
                else if (mce.Method.Name == "WEx_InNot")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" Not In (");
                    //ExpressionRouter(mce.Arguments[1]);
                    AlanyArrayObj(mce.Arguments[1]);
                    SqlWhere.Append(")");
                }
                else if (mce.Method.Name == "WEx_GreaterThenEqual")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" >=");
                    ExpressionRouter(mce.Arguments[1]);
                }
                else if (mce.Method.Name == "WEx_GreaterThen")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" >");
                    ExpressionRouter(mce.Arguments[1]);
                }
                else if (mce.Method.Name == "WEx_LessThanEqual")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" <=");
                    ExpressionRouter(mce.Arguments[1]);
                }
                else if (mce.Method.Name == "WEx_LessThan")
                {
                    AddExMethodFieldName(mce);
                    SqlWhere.Append(" <");
                    ExpressionRouter(mce.Arguments[1]);
                }
                else
                {
                    AlanyMemberRight(mce);
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// 解析右部分的所有方法
        /// </summary>
        void ExpressionRouter(Expression exp)
        {
            if (AlanyBinary(exp)) return;
            if (AlanyConstant(exp)) return;
            if (AlanyNewArray(exp)) return;
            if (AlanyMethod(exp)) return;
            if (AlanyMemberRight(exp)) return;
        }

        public void AnalySelectorExpression<TEntity>(Expression<Func<TEntity, object>> selector, Func<string, string> formatFieldNameFun)
        {
            SqlWhere.Clear();
            if (selector == null) return;
            this.FormatFieldNameFun = formatFieldNameFun;
            if (selector.Body is UnaryExpression)
            {
                UnaryExpression ue = ((UnaryExpression)selector.Body);
                AlanyLeft(ue.Operand);
            }
            else if (selector.Body is ConstantExpression)
            {
                var ce = (ConstantExpression)selector.Body;
                string fieldName = ce.Value.ToString();
                fieldName = formatFieldNameFun(fieldName);
                SqlWhere.Append(fieldName);
            }
            else if (selector.Body is MemberExpression)
            {
                var me = (MemberExpression)selector.Body;

                if (me.Member.DeclaringType.BaseType == typeof(Framework.Entitys.EntityBase))
                {
                    string fieldName = FormatFieldNameFun(me.Member.Name);
                    SqlWhere.Append(fieldName);
                }
                else
                {
                    object obj = Expression.Lambda(me).Compile().DynamicInvoke();
                    string fieldName = formatFieldNameFun(obj.ToString());
                    SqlWhere.Append(fieldName);
                }
            }
            else
            {
                throw new Exception("解析一元表达式出错,未支持当前语法");
            }
        }
        public void AnalyWhereExpression<T>(Expression<Func<T, bool>> whereExpr, Func<string, string> formatFieldNameFun, Func<object, string> addParamValueFun)
        {
            if (whereExpr == null) return;
            SqlWhere.Clear();
            this.FormatFieldNameFun = formatFieldNameFun;
            this.AddParamValueFun = addParamValueFun;
            if (!AlanyBinary(whereExpr.Body))
            {
                AlanyMethod(whereExpr.Body);
            }

        }
        public string GetValue()
        {
            return SqlWhere.ToString();
        }
    }
}