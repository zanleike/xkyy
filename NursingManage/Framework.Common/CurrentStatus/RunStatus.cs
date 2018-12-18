using System;
using System.Collections.Generic;
using System.Text;
using Framework.Common.Models;

namespace Framework.Common.CurrentStatus
{
    /// <summary>
    /// 获得登录信息的委托
    /// </summary>
    /// <returns>返回操作员信息</returns>
    public delegate IOperator LoginSystemDelegate();

    /// <summary>
    /// 登录状态
    /// </summary>
    public class RunStatus
    {
        public static bool Login(LoginSystemDelegate loginFun)
        {
            _CurrentOperator = loginFun();
            return _CurrentOperator == null ? false : true;
        }
        static IOperator _CurrentOperator;
        /// <summary>
        /// 当前操作员
        /// </summary>
        public static IOperator CurrentOperator
        {
            get { return _CurrentOperator; }
        }
        /// <summary>
        /// 判断程序是否以debug编译,默认是false
        /// </summary>
        public static bool IsDebug = false;
    }
}
