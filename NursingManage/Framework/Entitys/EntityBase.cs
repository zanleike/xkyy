/*
创建日期: 2015.8.18
    创建者:张存
    邮箱:zhangcunliang@126.com
    说明:
        实体对象的基类
    修改记录: 
        2015.11.8   增加扩展方法 WEx_GreaterThen,WEx_GreaterThenEqual,WEx_LessThan,WEx_LessThanEqual
                    实现字符串>=,>,<=,<的表达式解析
        2015.11.9   将扩展方法的fieldName 都改为object,支持直接表达式的类似 "s.Name"输入
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Framework.Entitys
{
    public abstract partial class EntityBase
    {
        public EntityBase()
        {
            _ChangedFields = new List<string>();
        }

        public bool WEx_In<T>(object fieldName, params T[] array)
        {
            return true;
        }
        public bool WEx_InNot<T>(object fieldName, params T[] array)
        {
            return true;
        }
        public bool WEx_Like(object fieldName, string likeStr)
        {
            return true;
        }
        public bool WEx_LikeNot(object fieldName, string likeStr)
        {
            return true;
        }
        public bool WEx_GreaterThen(object fieldName, string value)
        {
            return true;    //这个是用于字符串比较>
        }
        public bool WEx_GreaterThenEqual(object fieldName, string value)
        {
            return true;
        }
        public bool WEx_LessThan(object fieldName, string value)
        {
            return true;
        }
        public bool WEx_LessThanEqual(object fieldName, string value)
        {
            return true;
        }
        ///// <summary>
        ///// 设置指定属性值已改变，它将可能进行新增或更新字段
        ///// </summary>
        //public virtual void SetFieldChanged(string fieldName)
        //{
        //    if (!_ChangedFields.Contains(fieldName))
        //    {
        //        _ChangedFields.Add(fieldName);
        //    }
        //}
        /// <summary>
        /// 设置指定属性值已改变，它将可能进行新增或更新字段
        /// </summary>
        public virtual void SetFieldChanged(params string[] fieldNames)
        {
            foreach (var item in fieldNames)
            {
                if (!_ChangedFields.Contains(item))
                {
                    _ChangedFields.Add(item);
                }
            }
        }
        /// <summary>
        /// 设置所有字段值未改变状态，所有字段将不进行新增或更新
        /// </summary>
        public virtual void ClearChangedState()
        {
            _ChangedFields.Clear();
        }
        public virtual void ClearChangedState(string fieldName)
        {
            _ChangedFields.Remove(fieldName);
        }

        List<string> _ChangedFields;
        internal protected string[] GetChangedFields()
        {
            return _ChangedFields.ToArray();
        }        
        internal protected Dictionary<string, object> GetFieldNameValue()
        {
            var r = ReflectionHelper.GetPropertyNameAndValue(this);
            return r;
        }

        partial void ChangeBefore(string field);        
    }
}