using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Models
{
    public interface IOperator
    {
        /// <summary>
        /// 获得操作员Id
        /// </summary>
        string GetOperatorId();
        /// <summary>
        /// 获得操作员名称
        /// </summary>
        string GetOperatorName();
    }

}
