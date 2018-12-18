using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Exceptions
{
    public class PromptException: CommonException
    {
        public static string FriendlyMessage = "框架运行时出错!";

        public PromptException()
            : base(FriendlyMessage, string.Empty)
        { }

        public PromptException(string friendlyMessage, string message)
            : base(friendlyMessage, message)
        { }
        public PromptException(string message)
            : base(message)
        { }
    }
}
