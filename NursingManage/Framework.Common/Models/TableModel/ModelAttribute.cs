using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Models.TableModel
{
    public class ModelAttribute : Attribute
    {
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimaryKey  { set; get; }
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
    }
}
