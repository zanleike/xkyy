/*
    创建日期: 2013.12.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2014.1.13   增加 AddSearchObj 方法,用户加入一个ISearch对象
        2015.6.10   增加FormatFieldName(string) 方法,扩展Lambda调用
                    增加AndWhere 方法,扩展Lambda调用,如果调用项目为.net 3.5及以上,引用Framework.SqlWhereEx 可使用Lambda表达式生成where文本
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Models
{
    /// <summary>
    /// 2014.7.11 改对象正确含义应该是SearchHelper
    /// 排序加了进去,不仅仅处理Where条件哦
    /// </summary>
    public abstract class ISearch
    {
        #region 构造函数

        protected ISearch()
        {
            _WhereText = new StringBuilder();
            //临时处理,赋值了排序没有赋值where的解决 2014.9.18
            //_WhereText.Append(" where 1=1 ");
            _ParamDict = new Dictionary<string, object>();
            _OrderByText = new StringBuilder();

            _ParamNameKey = string.Empty;
        }
        //protected ISearch(ISearch wh)
        //    : this()
        //{
        //    this._LastParamIndex = wh._LastParamIndex;
        //    this._ParamDict = wh._ParamDict;
        //    this._WhereText = wh._WhereText;
        //    this._PNameKey = wh._ParamNameKey;
        //}

        #endregion

        #region 重写ToString
        /// <summary>
        /// 返回where条件及排序条件(合并排序条件在此生效)
        /// </summary>
        public override string ToString()
        {
            if (_WhereText.Length > 0)
            {
                return string.Format(" where {0} {1}", _WhereText, _OrderByText);
            }
            return string.Format(" {0}", _OrderByText);
        }

        #endregion

        #region 字段
        /// <summary>
        /// 参数名的索引名
        /// </summary>
        int _LastParamIndex = -1;
        /// <summary>
        /// where文本
        /// </summary>
        StringBuilder _WhereText;
        /// <summary>
        /// 参数字典列表
        /// </summary>
        Dictionary<string, object> _ParamDict;
        /// <summary>
        /// 排序字符串,在tostring时才增加到文本最后
        /// </summary>
        StringBuilder _OrderByText;
        /// <summary>
        /// 备注标记,记录一个键的标识,如记录已经添加某条件后不再重复添加
        /// </summary>
        object _Tag;
        
        #endregion

        #region 属性及公共成员

        /// <summary>
        /// 获取where条件的字符串
        /// </summary>
        public string WhereTextStr
        {
            get
            {
                if (_WhereText == null || _WhereText.Length == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return string.Format(" where {0}", _WhereText);
                }

            }
        }
        /// <summary>
        /// 获取排序的字符串(含order by)
        /// </summary>
        public string OrderByTextStr
        {
            get
            {
                if (_OrderByText == null) return string.Empty;
                return _OrderByText.ToString();
            }
        }
        /// <summary>
        /// 返回当前对象所有产品参数集合字典,key:参数数名(包含@),value:参数值
        /// </summary>
        public Dictionary<string, object> ParamDict
        {
            get
            {
                return _ParamDict;
            }
        }
        /// <summary>
        /// 返回当前生成where文本,可对文本进行append操作
        /// </summary>
        public StringBuilder WhereText
        {
            get
            {
                return _WhereText;
            }
        }

        /// <summary>
        /// 参数名的基础字符
        /// 如需合并两个ISearch对象时用到,参数名不能重复
        /// </summary>
        string _ParamNameKey;
        /// <summary>
        /// 参数名的基础字符
        /// 如需合并两个ISearch对象时用到,参数名不能重复
        /// </summary>
        public string ParamNameKey
        {
            get { return _ParamNameKey; }
            set { _ParamNameKey = value; }
        }
        /// <summary>
        /// 备注标记,记录一个键的标识,如记录已经添加某条件后不再重复添加
        /// </summary>
        public object Tag
        {
            get { return _Tag; }
            set { _Tag = value; }
        }
        /// <summary>
        /// 参数符号字符串
        /// </summary>
        public string ParamSignStr { set; get; }

        public delegate string FormatFieldNameHandle(string fieldName);
        /// <summary>
        /// 格式化字段格式的委托方法
        /// </summary>
        public FormatFieldNameHandle FormatFieldNameFun;

        #region 分页的属性们

        int _PageNo = 1;
        /// <summary>
        /// 分页查询时页码,如果小于0则返回1
        /// </summary>
        public int PageNo
        {
            get
            {
                if (_PageNo <= 0) _PageNo = 1;
                return _PageNo;
            }
            set { _PageNo = value; }
        }
        int _OnePage = 0;
        /// <summary>
        /// 分页查询时每页显示数(默认0不分页)
        /// </summary>
        public int OnePage
        {
            get { return _OnePage; }
            set { _OnePage = value; }
        }
        int _RecordCount;
        /// <summary>
        /// 分页查询时输出的记录数
        /// </summary>
        public int RecordCount
        {
            get { return _RecordCount; }
            set { _RecordCount = value; }
        }
        /// <summary>
        /// 分页查询时出书的页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (IsUsePage)
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

        /// <summary>
        /// 是否使用分页了,如果OnePage为0,则不启用分页
        /// </summary>
        public bool IsUsePage
        {
            get
            {
                return (_PageNo > 0 && _OnePage > 0) ? true : false;
            }
        }

        #endregion

        #endregion

        #region 方法们

        /// <summary>
        /// 加入一个Search对象的Where条件合并到当前ISearch对象中,
        /// 创建Search后需要设置ParamNameKey值,该不能重复,初始值为Empty
        /// </summary>
        public virtual ISearch MergeWhereSearch(ISearch searchObj)
        {
            if (this._ParamNameKey.Equals(searchObj._ParamNameKey, StringComparison.CurrentCultureIgnoreCase))
            {
                //在这里判断而不处理,是因为如果要合并多个需要判断将
                //其实复杂的和合并仍然解决不了
                throw new Exception("要合并的Search对象ParamNameKey和当前Search对象的ParamNameKey相同!");
            }
            if (this.WhereText == null) this._WhereText = new StringBuilder();
            this.WhereText.AppendFormat(" {0} ", searchObj.WhereTextStr);
            if (searchObj.ParamDict != null)
            {
                if (this._ParamDict == null) this._ParamDict = new Dictionary<string, object>();
                foreach (var item in searchObj.ParamDict.Keys)
                {
                    this._ParamDict.Add(item, searchObj.ParamDict[item]);
                }
            }

            return this;
        }
        /// <summary>
        /// 克隆一个ISearch对象,因为创建问题,输入一个实例化的空ISearch对象,赋值后返回
        /// </summary>
        /// <param name="wh">输出的ISearch对象</param>
        protected virtual void CloneISearch(ISearch wh)
        {
            wh.Clear();
            wh._LastParamIndex = this._LastParamIndex;
            wh._OnePage = this._OnePage;
            wh._OrderByText = new StringBuilder(this._OrderByText.ToString());
            wh._PageNo = this._PageNo;
            wh._ParamDict = new Dictionary<string, object>();
            foreach (string item in this._ParamDict.Keys)
            {
                wh._ParamDict.Add(item, this._ParamDict[item]);
            }
            wh._ParamNameKey = this._ParamNameKey;
            wh._RecordCount = this._RecordCount;
            wh.ParamSignStr = this.ParamSignStr;
            wh._WhereText = new StringBuilder(this._WhereText.ToString());
        }
        /// <summary>
        /// 克隆一个ISearch对象,因为创建问题,输入一个实例化的空ISearch对象,赋值后返回
        /// </summary>
        public abstract ISearch Clone();

        /// <summary>
        /// 设置配需sql文,从现在开始,改对象名字其实应该叫做SearchHelper,ISearch已经合适了2014.7.11
        /// </summary>
        protected virtual void SetOrderText(string fieldName, bool isDesc)
        {
            if (_OrderByText == null)
            {
                _OrderByText = new StringBuilder();
            }
            string orderByDesc = isDesc ? "Desc" : "Asc";
            if (_OrderByText.Length == 0)
            {
                this._OrderByText.AppendFormat(" order by {0} {1}", fieldName, orderByDesc);
            }
            else
            {
                this._OrderByText.AppendFormat(",{0} {1}", fieldName, orderByDesc);
            }
        }
        /// <summary>
        /// 增加查询参数,并得到参数名,参数名会根据LastParamIndex递增
        /// </summary>
        /// <param name="v">参数值</param>
        /// <returns>返回参数名</returns>
        public string AddParamGetParamName(object v)
        {
            _LastParamIndex++;
            string paramName = string.Format("{2}P_{1}{0}", _LastParamIndex, _ParamNameKey, ParamSignStr);
            _ParamDict.Add(paramName, v);
            return paramName;
        }
        /// <summary>
        /// 格式化字段名的方法,默认为不格式化
        /// </summary>
        public virtual string FormatFieldName(string fieldName)
        {
            if (FormatFieldNameFun != null)
            {
                return FormatFieldNameFun(fieldName);
            }
            return fieldName;
        }
        /// <summary>
        /// 增加一个where文本和参数到该查询中,可用于扩展Lambda
        /// </summary>
        public void AndWhere(string whereText, Dictionary<string, object> paramDict)
        {
            if (paramDict != null && paramDict.Count > 0)
            {
                string newParamName;
                foreach (var paramName in paramDict.Keys)
                {
                    if (_ParamDict.ContainsKey(paramName))
                    {
                        newParamName = paramName + "_2";
                        whereText = whereText.Replace(paramName, newParamName);
                    }
                    else
                    {
                        newParamName = paramName;
                    }
                    _ParamDict.Add(newParamName, paramDict[paramName]);
                }
            }
            if (_WhereText.Length > 2)
            {
                _WhereText.Insert(0, "(");
                _WhereText.Append(")");
            }
            _WhereText.AppendFormat(" AND {0} ", whereText);
        }

        /// <summary>
        /// 清除where文本内容,参数内容和排序内容
        /// </summary>
        public void Clear()
        {
            _ParamDict.Clear();
            _WhereText.Remove(0, _WhereText.Length);
            _OrderByText.Remove(0, _OrderByText.Length);
            _Tag = null;
        }
        /// <summary>
        /// 增加一个参数,自动获得参数名及增加参数
        /// </summary>
        public virtual ISearch AddParam(object p)
        {
            string paramName = AddParamGetParamName(p);
            this._WhereText.Append(paramName);
            return this;
        }
        /// <summary>
        /// 当前where文本增加字符(通常该值是 字段名 ),返回当前对象
        /// </summary>
        public virtual ISearch Add(string str)
        {
            this._WhereText.AppendFormat(" {0} ", str);
            return this;
        }
        /// <summary>
        /// 合并一个ISearch,并用and连接起来,并在前后语句加上括号
        /// </summary>
        public virtual ISearch AddSearchObj(ISearch serObj)
        {
            serObj.AddGroup();
            return this.AddGroup().And().MergeWhereSearch(serObj);
            
        }
        /// <summary>
        /// 比较符,等于 "="
        /// </summary>
        public virtual ISearch Equal(object v)
        {
            this._WhereText.AppendFormat(" = {0}", AddParamGetParamName(v));
            return this;
        }
        /// <summary>
        /// 比较符,不等于 "!="
        /// </summary>
        public virtual ISearch EqualNot(object v)
        {
            _WhereText.AppendFormat(" <> {0}", AddParamGetParamName(v));
            return this;
        }
        /// <summary>
        /// 比较符,大于 ">"
        /// </summary>
        public virtual ISearch GreaterThan(object v)
        {
            this._WhereText.AppendFormat(" > {0}", AddParamGetParamName(v));
            return this;
        }
        /// <summary>
        /// 比较符,小于
        /// </summary>
        public virtual ISearch LessThan(object v)
        {
            this._WhereText.AppendFormat(" < {0}", this.AddParamGetParamName(v));
            return this;
        }
        /// <summary>
        /// 比较符,大于等于
        /// </summary>
        public virtual ISearch GreaterThenEqual(object v)
        {
            this._WhereText.AppendFormat(" >= {0}", this.AddParamGetParamName(v));
            return this;
        }
        /// <summary>
        /// 比较符,小于等于
        /// </summary>
        public virtual ISearch LessThanEqual(object v)
        {
            this._WhereText.AppendFormat(" <= {0}", this.AddParamGetParamName(v));
            return this;
        }
        /// <summary>
        /// 是否空
        /// </summary>
        public virtual ISearch IsNull()
        {
            this.WhereText.Append(" is null ");
            return this;
        }
        /// <summary>
        /// 是否非空
        /// </summary>
        public virtual ISearch IsNotNull()
        {
            this.WhereText.Append(" is not null ");
            return this;
        }
        /// <summary>
        /// 比较符,In,参数为某范围内的比较值
        /// </summary>
        //public virtual ISearch In(params object[] inArgs)
        public virtual ISearch In(object[] inArgs)
        {
            this._WhereText.Append(" in (");
            for (int i = 0; i < inArgs.Length; i++)
            {
                _WhereText.Append(AddParamGetParamName(inArgs[i]));
                if (i < inArgs.Length - 1)
                {
                    _WhereText.Append(",");
                }
            }
            this._WhereText.Append(" )");
            return this;
        }
        /// <summary>
        /// 比较符,NotIn
        /// </summary>
        public virtual ISearch NotIn(params object[] inArgs)
        {
            this._WhereText.Append(" not in (");
            for (int i = 0; i < inArgs.Length; i++)
            {
                _WhereText.Append(AddParamGetParamName(inArgs[i]));
                if (i < inArgs.Length - 1)
                {
                    _WhereText.Append(",");
                }
            }
            this._WhereText.Append(" )");
            return this;
        }
        /// <summary>
        /// 比较符 left Like %{0}
        /// </summary>
        public virtual ISearch LikeLeft(string v)
        {
            string addParam = AddParamGetParamName(string.Format("%{0}", v));
            this._WhereText.AppendFormat(" like {0}", addParam);
            return this;
        }
        /// <summary>
        /// 比较符 right like {0}%
        /// </summary>
        public virtual ISearch LikeRight(string v)
        {
            string addParam = AddParamGetParamName(string.Format("{0}%", v));
            this._WhereText.AppendFormat(" like {0}", addParam);
            return this;
        }
        /// <summary>
        /// 比较符 full like
        /// </summary>
        public virtual ISearch LikeFull(string v)
        {
            string addParam = AddParamGetParamName(string.Format("%{0}%", v));
            this._WhereText.AppendFormat(" like {0}", addParam);
            return this;
        }
        /// <summary>
        /// 增加一个左括号 "("
        /// </summary>
        public virtual ISearch BracketLeft()
        {
            this._WhereText.AppendFormat("(");
            return this;
        }
        /// <summary>
        /// 增加一个左括号"(",再加一个字符串(通常是一个字段)
        /// </summary>
        public virtual ISearch BracketLeft(string str)
        {
            this._WhereText.AppendFormat("(");
            this._WhereText.AppendFormat(str);
            return this;
        }
        /// <summary>
        /// 增加一个右括号 ")"
        /// </summary>
        public virtual ISearch BracketRight()
        {
            this._WhereText.Append(")");
            return this;
        }
        /// <summary>
        /// 增加一个右括号")",再加一个字符串(通常是一个字段)
        /// </summary>
        public virtual ISearch BracketRight(string str)
        {
            this._WhereText.AppendFormat(")");
            this._WhereText.AppendFormat(str);
            return this;
        }
        /// <summary>
        /// 增加连接符 "and"
        /// </summary>
        public virtual ISearch And()
        {
            And(string.Empty);
            return this;
        }
        /// <summary>
        /// 增加连接符 "and"
        /// </summary>
        public virtual ISearch And(string str)
        {
            if (this._WhereText.Length > 0)
            {
                this._WhereText.Append(" and ");
            }
            this._WhereText.Append(str);
            return this;
        }
        /// <summary>
        /// 增加连接符 "or"
        /// </summary>
        public virtual ISearch Or()
        {
            Or(string.Empty);
            return this;
        }
        /// <summary>
        /// 增加连接符"or",再加一个字符串(通常是一个字段)
        /// </summary>
        public virtual ISearch Or(string str)
        {
            if (this._WhereText.Length > 0)
            {
                this._WhereText.Append(" or ");
            }
            this._WhereText.Append(str);
            return this;
        }
        /// <summary>
        /// 如果有内容增加一组括号,即在首位加"(" ,末尾加 ")"
        /// </summary>
        public virtual ISearch AddGroup()
        {
            if (this._WhereText.Length > 0)
            {
                this._WhereText.Insert(0, "(");
                this._WhereText.Append(")");
            }
            return this;
        }
        /// <summary>
        /// 设置指定字段按升序排序
        /// </summary>
        public virtual ISearch OrderByAsc(string fieldName)
        {
            SetOrderText(fieldName, false);
            return this;
        }
        /// <summary>
        /// 设置指定字段按降序排序
        /// </summary>
        public virtual ISearch OrderByDesc(string fieldName)
        {
            SetOrderText(fieldName, true);
            return this;
        }

        #endregion
    }
}
