using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Exceptions
{
   public class DbDataException : CommonException
    {
        /// <summary>
        /// 缺省的FriendlyMessage
        /// </summary>
        public static string Default = "数据库操作异常！";

        /// <summary>
        /// 如果没有传入任何参数，使用Default作为FriendlyMessage
        /// </summary>
        public DbDataException() : base(Default, string.Empty) { }

        /// <summary>
        /// 使用Default作为FriendlyMessage
        /// </summary>
        /// <param name="message">需要记录在日志中的其他信息</param>
        public DbDataException(string message) : base(Default, message) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="friendlyMessage">显示给用户看的友好信息</param>
        /// <param name="message">需要记录在日志中的其他信息</param>
        public DbDataException(string friendlyMessage, string message) : base(friendlyMessage, message) { }
    }
}
