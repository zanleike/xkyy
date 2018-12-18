using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Entitys
{
    public abstract class EntityAnaly : IEntityAnaly
    {
        static object _LockObj1 = new object();
        static object _LockObj2 = new object();
        static object LockObj_TableNameCache = new object();
        /// <summary>
        /// 实体类缓存,静态变量是保存为了减少反射次数
        /// </summary>
        static Dictionary<Type, Dictionary<string, EntityAttribute>> _ModelAttributeCache;
        /// <summary>
        /// 表名的缓存列表,获取后不再重新反射获取
        /// </summary>
        static Dictionary<Type, string> _TableNameCache;

        /// <summary>
        /// 实体类缓存,静态变量是保存为了减少反射次数
        /// </summary>
        protected Dictionary<Type, Dictionary<string, EntityAttribute>> ModelAttributeCache
        {
            get
            {
                if (_ModelAttributeCache == null)
                {
                    lock (_LockObj1)
                    {
                        if (_ModelAttributeCache == null)
                        {
                            _ModelAttributeCache = new Dictionary<Type, Dictionary<string, EntityAttribute>>();
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
        protected Dictionary<string, EntityAttribute> GetEntityAttribute<T>() where T : EntityBase, new()
        {
            Type t = typeof(T);
            if (!ModelAttributeCache.ContainsKey(t))
            {
                lock (_LockObj2)
                {
                    if (!ModelAttributeCache.ContainsKey(t))
                    {
                        var attrs = GetAttribute<T>();
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
        protected abstract Dictionary<string, EntityAttribute> GetAttribute<T>() where T : EntityBase, new();
        /// <summary>
        /// 根据Model类型获取表名
        /// </summary>
        public abstract string GetTableNameMy<TEntity>() where TEntity : EntityBase, new();
        /// <summary>
        /// 获取表名,
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public string GetTableName<TEntity>() where TEntity : EntityBase, new()
        {
            if (_TableNameCache == null)
            {
                _TableNameCache = new Dictionary<Type, string>();
            }
            Type type = typeof(TEntity);

            if (!_TableNameCache.ContainsKey(type))
            {
                lock (LockObj_TableNameCache)
                {
                    if (!_TableNameCache.ContainsKey(type))
                    {
                        string tableName = GetTableNameMy<TEntity>();
                        _TableNameCache.Add(type, tableName);
                    }
                }
            }

            return _TableNameCache[type];
        }
        /// <summary>
        /// 根据对象的属性名称,反射获取到属性值
        /// </summary>
        public virtual object GetPropertyValue<TEntity>(TEntity entity, string propertyName) where TEntity : EntityBase, new()
        {
            object obj = ReflectionHelper.GetPropertyValue(entity, propertyName);
            return obj;
        }

        public string[] GetAllFields<TEntity>() where TEntity : EntityBase, new()
        {
            var attr = GetEntityAttribute<TEntity>();
            return attr.Keys.ToArray();
        }

        public EntityAttribute GetAttribute<TEntity>(TEntity entity, string propertyName) where TEntity : EntityBase, new()
        {
            var attr = GetEntityAttribute<TEntity>();
            return attr[propertyName];
        }

        public string[] GetPrimaryKey<TEntity>() where TEntity : EntityBase, new()
        {
            var attr = GetEntityAttribute<TEntity>();
            List<string> pkList = new List<string>();
            foreach (var item in attr.Values)
            {
                if (item.IsPrimaryKey)
                {
                    pkList.Add(item.ColumnName);
                }
            }
            return pkList.ToArray();
        }
    }
}