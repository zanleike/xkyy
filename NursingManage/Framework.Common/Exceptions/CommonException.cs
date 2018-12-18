using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Exceptions
{
    public class CommonException : ApplicationException
    {
        /// <summary>
        /// 缺省的FriendlyMessage
        /// </summary>
        public static string CommonDefaultFriendlyMessage = "系统出现错误，请与管理员联系！";

        /// <summary>
        /// 显示给用户看的友好信息
        /// </summary>
        protected string _friendlyMessage;
        public string FriendMessage
        {
            get
            {
                return this._friendlyMessage;
            }
        }

        /// <summary>
        /// 如果没有传入参数，使用Default值作为FriendlyMessage
        /// </summary>
        public CommonException() : this(CommonDefaultFriendlyMessage, string.Empty) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">需要记录在日志中的其他信息</param>
        public CommonException(string message) : this(CommonDefaultFriendlyMessage, message) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="friendlyMessage">显示给用户看的友好信息</param>
        /// <param name="message">需要记录在日志中的其他信息</param>
        public CommonException(string friendlyMessage, string message)
            : base(message)
        {
            this._friendlyMessage = friendlyMessage;
        }

    }
}
