using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HursingManage.AL
{
    public class ViewResultBase
    {
        bool _IsSuccess;
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess
        {
            get { return string.IsNullOrWhiteSpace(_ErrMessage); }
        }
        string _ErrMessage;
        /// <summary>
        /// 如果IsSuccess为false,则返回错误信息,由UI提示;该值为空则IsSuccess为true,否则false
        /// </summary>
        public string ErrMessage
        {
            get { return _ErrMessage; }
            set { _ErrMessage = value; }
        }
    }
    public class ViewReusltObject<TReuslt> : ViewResultBase
    {
        public TReuslt ReusltValue { set; get; }
    }
    public class ViewResultString : ViewReusltObject<string>
    { }
    public class ViewResultInt : ViewReusltObject<int>
    { }
    public class ViewResultDecimal : ViewReusltObject<decimal>
    { }
    public class ViewResultDateTime : ViewReusltObject<DateTime>
    { }
}
