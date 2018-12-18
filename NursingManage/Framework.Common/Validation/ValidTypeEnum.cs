using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Validation
{
    public enum ValidTypeEnum
    {
        /// <summary>
        /// 不做验证
        /// </summary>
        None,
        /// <summary>
        /// 非空验证
        /// </summary>
        NotNull,
        /// <summary>
        /// 数据类型
        /// </summary>
        DataType,
        /// <summary>
        /// 匹配该正则表达式
        /// </summary>
        EqualToRegex,
        /// <summary>
        /// 该表达式除外
        /// </summary>
        EqualNotRegex
    }
}
