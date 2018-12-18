using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Framework.Common
{
    /// <summary>
    /// 数据转换类,此类定义了所有通用类型转换的方法
    /// </summary>
    public class ConvertData
    {
        /// <summary>
        /// 将字符串值转换为枚举,如果指定字符串不存在改枚举中则会引发异常
        /// </summary>
        /// <typeparam name="T">要转换的枚举类型</typeparam>
        /// <param name="enumStr">参数:枚举字符串</param>
        /// <returns>返回结果枚举</returns>
        public static T StringToEnum<T>(string enumStr)
        {
            string[] enumNames = Enum.GetNames(typeof(T));
            for (int i = 0; i < enumNames.Length; i++)
            {
                if (enumStr.Equals(enumNames[i], StringComparison.CurrentCultureIgnoreCase))
                {
                    return (T)Enum.Parse(typeof(T), enumStr);
                }
            }
            return (T)Enum.Parse(typeof(T), enumNames[0]);
        }
        /// <summary>
        /// 将DataRow转换为实体对象,如果实体类属性中不包含列则忽略
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="dr">要转换的行对象</param>
        /// <returns>返回实体对象</returns>
        public static T DataRowToModel<T>(DataRow dr) where T : new()
        {
            if (dr == null || dr.Table == null) return default(T);
            T model = new T();
            Type type = model.GetType();
            System.Reflection.PropertyInfo[] pros = type.GetProperties();
            if (pros == null || pros.Length == 0) return default(T);
            DataColumnCollection tbColumns = dr.Table.Columns;
            foreach (var item in pros)
            {
                if (!item.CanWrite) continue;
                string sName = item.Name;
                if (!tbColumns.Contains(sName)) continue;
                if (dr[sName] != null && dr[sName].ToString().Trim() != string.Empty)
                {
                    //如果DataReader没有将数据分类型存储,则使用以下方法转换
                    //object obj = Convert.ChangeType(dr[sName], item.GetType());
                    item.SetValue(model, dr[sName], null);
                }
            }
            return model;
        }
        /// <summary>
        /// 将DataTable转换为List集合
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="dt">要转换的DataTable对象</param>
        /// <returns>返回实体集合对象</returns>
        public static List<T> DataTableToModel<T>(DataTable dt) where T : new()
        {
            if (dt == null || dt.Rows.Count == 0 || dt.Columns.Count == 0)
                return null;
            List<T> list = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                T t = DataRowToModel<T>(dt.Rows[0]);
                list.Add(t);
            }
            return list;
        }
        /// <summary>
        /// 根据字符串获取对应类型(Type)
        /// </summary>
        /// <param name="type">类型字符串</param>
        /// <returns>返回类型</returns>
        public static Type GetTypeByString(string type)
        {
            switch (type.ToLower())
            {
                case "bool":
                    return Type.GetType("System.Boolean", true, true);
                case "byte":
                    return Type.GetType("System.Byte", true, true);
                case "sbyte":
                    return Type.GetType("System.SByte", true, true);
                case "char":
                    return Type.GetType("System.Char", true, true);
                case "decimal":
                    return Type.GetType("System.Decimal", true, true);
                case "double":
                    return Type.GetType("System.Double", true, true);
                case "float":
                    return Type.GetType("System.Single", true, true);
                case "int":
                    return Type.GetType("System.Int32", true, true);
                case "uint":
                    return Type.GetType("System.UInt32", true, true);
                case "long":
                    return Type.GetType("System.Int64", true, true);
                case "ulong":
                    return Type.GetType("System.UInt64", true, true);
                case "object":
                    return Type.GetType("System.Object", true, true);
                case "short":
                    return Type.GetType("System.Int16", true, true);
                case "ushort":
                    return Type.GetType("System.UInt16", true, true);
                case "string":
                    return Type.GetType("System.String", true, true);
                case "date":
                case "datetime":
                    return Type.GetType("System.DateTime", true, true);
                case "guid":
                    return Type.GetType("System.Guid", true, true);
                default:
                    return Type.GetType(type, true, true);
            }
        }
    }
}
