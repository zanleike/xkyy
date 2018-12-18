using System;
using System.Collections.Generic;
using System.Text;
using Framework.Common.Helpers;

namespace Framework.Common.Models.TableModel
{
    /// <summary>
    /// Model实体的解析接口
    /// </summary>
    public abstract class ModelAnaly
    {
        static object _LockObj1 = new object();
        static object _LockObj2 = new object();

        /// <summary>
        /// 实体类缓存,静态变量是保存为了减少反射次数
        /// </summary>
        static Dictionary<Type, Dictionary<string, ModelAttribute>> _ModelAttributeCache;
        /// <summary>
        /// 实体类缓存,静态变量是保存为了减少反射次数
        /// </summary>
        protected Dictionary<Type, Dictionary<string, ModelAttribute>> ModelAttributeCache
        {
            get
            {
                if (_ModelAttributeCache == null)
                {
                    lock (_LockObj1)
                    {
                        if (_ModelAttributeCache == null)
                        {
                            _ModelAttributeCache = new Dictionary<Type, Dictionary<string, ModelAttribute>>();
                        }
                    }
                }
                return _ModelAttributeCache;
            }
        }
        /// <summary>
        /// 获取Model的属性对象,获取第一次后会放入一个缓存列表中
        /// 即只反射一次
        /// </summary>
        public Dictionary<string, ModelAttribute> GetModelAttribute<T>() where T : ModelBase, new()
        {
            Type t = typeof(T);
            if (!ModelAttributeCache.ContainsKey(t))
            {
                lock (_LockObj2)
                {
                    if (!ModelAttributeCache.ContainsKey(t))
                    {
                        var attrs = GetModelParam<T>();
                        ModelAttributeCache.Add(t, attrs);
                    }
                }
            }
            return ModelAttributeCache[t];
        }
        /// <summary>
        /// 通过解析获得Model的对象的参数,Key:为类的属性名
        /// </summary>
        /// <param name="model">model对象</param>
        /// <returns>返回model参数</returns>
        protected abstract Dictionary<string, ModelAttribute> GetModelParam<T>() where T : ModelBase, new();
        /// <summary>
        /// 根据Model类型获取表名
        /// </summary>
        public abstract string GetTableName<T>() where T : class,  new();
    }
}
