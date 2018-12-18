using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Entitys
{
    public class EntityInfo
    {
        public string PropertyName { set; get; }

        public EntityAttribute PropertyAttribute { set; get; }

    }

    interface IEntityAnaly
    {
        /// <summary>
        /// 获取对象的属性值
        /// </summary>
        /// <param name="propertyName">属性名</param>
        /// <returns></returns>
        object GetPropertyValue<TEntity>(TEntity entity, string propertyName) where TEntity : EntityBase, new();

        string[] GetAllFields<TEntity>() where TEntity : EntityBase, new();

        EntityAttribute GetAttribute<TEntity>(TEntity entity,string propertyName) where TEntity : EntityBase, new();

        string GetTableName<TEntity>() where TEntity : EntityBase, new();

        string[] GetPrimaryKey<TEntity>() where TEntity : EntityBase, new();
    }
}