using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Exceptions
{
    public class FrameworkException : CommonException
    {
        public static string FriendlyMessage = "框架运行时出错!";

        public FrameworkException()
            : base(FriendlyMessage, string.Empty)
        { }

        public FrameworkException(string friendlyMessage, string message)
            : base(friendlyMessage, message)
        { }
        public FrameworkException(string message)
            : base(message)
        { }
    }
}
