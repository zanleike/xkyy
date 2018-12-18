using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Framework.Common.Helpers;

namespace Framework.Common.Models.TableModel
{
    /// <summary>
    /// 使用反射来解析Model
    /// </summary>
    public class ModelAnalyReflect: ModelAnaly
    {
        public ModelAnalyReflect() { }
        /// <summary>
        /// 获取表名
        /// </summary>
        public override string GetTableName<TModel>()
        {   
            string str = typeof(TModel).ToString();
            int a = str.LastIndexOf('.');
            string rStr = str.Substring(a + 1);
            return rStr;
        }
        /// <summary>
        /// 通过解析获得Model的对象的参数,Key:为类的属性名
        /// </summary>
        /// <param name="model">model对象</param>
        /// <returns>返回model参数</returns>
        protected override Dictionary<string, ModelAttribute> GetModelParam<TModel>()
        {
            var list = new Dictionary<string, ModelAttribute>();
            PropertyInfo[] pros = ReflectionHelper.GetPropertyInfo<TModel>();
            foreach (PropertyInfo item in pros)
            {
                var attr = ReflectionHelper.GetCustomAttribute<ModelAttribute>(item);
                if (attr == null)
                {
                    //如果实体没定义属性则创建一个新的
                    attr = new ModelAttribute();
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
