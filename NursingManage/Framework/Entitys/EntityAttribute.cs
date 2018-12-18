using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Entitys
{
    public class EntityAttribute : Attribute
    {
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimaryKey { set; get; }
        /// <summary>
        /// 主键是否自动增长
        /// </summary>
        public bool IsIdentity { set; get; }
        /// <summary>
        /// 是否非空字段
        /// </summary>
        public bool IsNotNull { set; get; }
        /// <summary>
        /// 列名
        /// </summary>
        public string ColumnName { set; get; }
        /// <summary>
        /// 默认false为字段属性,如果为true则表示不是一个字段
        /// </summary>
        public bool IsNotField { set; get; }
    }
    public class EntiryClassAttribute : Attribute
    {
        public string TableName { set; get; }
    }

}
