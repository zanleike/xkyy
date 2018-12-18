using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HursingManage.WebServer.Controllers
{
    public class AuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        #region IAuthorizationFilter 成员

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var ctl = filterContext.Controller as Controller;
            if (ctl != null)
            {
                var userObj = SessionHelper.GetSession(ctl, SessionKeyEnum.UserInfo);
                if (userObj != null)
                {
                    //只有这一种情况不跳转至登录页面
                    return;
                }
            }
            filterContext.Result = new RedirectResult("~/Login/Index");
        }

        #endregion
    }

    /// <summary>
    /// 定义sessionHelper是为了处理session值可以使用其它方式保存,或设置session时可以处理一些额外问题
    /// </summary>
    public class SessionHelper
    {
        public static void SetSession(Controller ctl, SessionKeyEnum sessionKey, object valueObj)
        {
            string keyStr = sessionKey.ToString();
            ctl.Session[keyStr] = valueObj;
        }
        public static object GetSession(Controller ctl, SessionKeyEnum sessionKey)
        {
            string keyStr = sessionKey.ToString();
            object SessionValue = ctl.Session[keyStr];
            return SessionValue;
        }
    }
    public enum SessionKeyEnum
    {
        /// <summary>
        /// 登录用户
        /// </summary>
        UserInfo
    }
}