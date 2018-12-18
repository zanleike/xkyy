/*
 
    2016.4.28   增加了实体对象中IsNotField属性,如果为true则表示不是一个数据库字段,字段相关信息会排除
 */

using System.Collections.Generic;
using System.Reflection;

namespace Framework.Entitys
{
    class EntityAnalyReflect : EntityAnaly
    {
        public EntityAnalyReflect() { }
        /// <summary>
        /// 获取表名
        /// </summary>
        public override string GetTableNameMy<TEntity>()
        {
            var classAttr = ReflectionHelper.GetClassAttribute<EntiryClassAttribute, TEntity>();
            if (classAttr != null)
            {
                return classAttr.TableName;
            }
            else
            {
                string str = typeof(TEntity).ToString();
                int a = str.LastIndexOf('.');
                string rStr = str.Substring(a + 1);
                return rStr;
            }
        }
        /// <summary>
        /// 通过解析获得Model的对象的参数,Key:为类的属性名
        /// </summary>
        /// <param name="model">model对象</param>
        /// <returns>返回model参数</returns>
        protected override Dictionary<string, EntityAttribute> GetAttribute<TEntity>()
        {
            var list = new Dictionary<string, EntityAttribute>();
            PropertyInfo[] pros = ReflectionHelper.GetPropertyInfo<TEntity>();
            foreach (PropertyInfo item in pros)
            {
                var attr = ReflectionHelper.GetCustomAttribute<EntityAttribute>(item);
                if (attr.IsNotField) continue;
                if (attr == null)
                {
                    //如果实体没定义属性则创建一个新的
                    attr = new EntityAttribute();
                    attr.ColumnName = item.Name;
                }
                else
                {
                    //如果列名没有赋值,则将列名定义和属性名一样的值
                    if (string.IsNullOrEmpty(attr.ColumnName))
                    {
                        attr.ColumnName = item.Name;
                    }
                }
                list.Add(item.Name, attr);
            }
            return list;
        }
    }
}