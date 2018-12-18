using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.WinCommon.AdvanceSearch
{
    /// <summary>
    /// 比较符枚举,大于 小于 In like 等
    /// </summary>
    public enum CompareSignEnum
    {
        /// <summary>
        /// 等于 
        /// </summary>
        EqualTo,
        /// <summary>
        /// 大于 
        /// </summary>
        GreaterThan,
        /// <summary>
        /// 大于等于
        /// </summary>
        GreaterThanOrEqual,
        /// <summary>
        /// 小于 
        /// </summary>
        LessThan,
        /// <summary>
        /// 小于等于 
        /// </summary>
        LessThanOrEqual,
        /// <summary>
        /// 不等于
        /// </summary>
        NotEqualTo,
        /// <summary>
        /// 字段 Like '%value'
        /// </summary>
        Like,
        /// <summary>
        /// not Like '%value'
        /// </summary>
        NotLike,
    }
}
