using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Validation
{
    public class ValidationModel
    {
        object _ValidObject;
        /// <summary>
        /// 要验证的值
        /// </summary>
        public object ValidObject
        {
            get { return _ValidObject; }
            set { _ValidObject = value; }
        }

        public ValidTypeEnum ValidType { set; get; }
        public DataTypeEnum DataType { set; get; }
        public string MaxValue { set; get; }
        public string MinValue { set; get; }
        public string CompareValue { set; get; }
        /// <summary>
        /// 出错后显示的错误消息
        /// </summary>
        public string ErrMessage { set; get; }
    }
}
