using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Framework.Common.Models.ProcedureModel
{
    /// <summary>
    /// 存储过程参数的特性类
    /// </summary>
    public class ProcedureOutParamAttribute : Attribute
    {
        public ProcedureOutParamAttribute()
        {
            _ParamDirection = ParameterDirection.Output;
            _OutSize = 50;
        }
        public ProcedureOutParamAttribute(ParameterDirection paramDirection)
        {
            _ParamDirection = paramDirection;
        }

        ParameterDirection _ParamDirection;
        /// <summary>
        /// 存储过程输出参数的方向类型
        /// </summary>
        public ParameterDirection ParamDirection
        {
            get { return _ParamDirection; }
            set { _ParamDirection = value; }
        }
        int _OutSize;
        /// <summary>
        /// 输出参数的字节数,默认50个字节
        /// </summary>
        public int OutSize
        {
            get { return _OutSize; }
            set { _OutSize = value; }
        }
    }
}
