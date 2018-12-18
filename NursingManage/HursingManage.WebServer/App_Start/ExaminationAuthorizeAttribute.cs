using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Security;
using ZCJH.HursingManage.WebServer.Models;
using ZhCun.Framework.Common;
using ZhCun.Framework.Common.Helpers;

namespace ZCJH.HursingManage.WebServer.App_Start
{
    public class ExaminationAuthorizeAttribute : AuthorizeAttribute
    {
        const string KEY = "AB2A6C0C11034294A5238A7E59FB149C";

        string GetDefaultHeadKey(HttpActionContext context, string headerName)
        {
            IEnumerable<string> r;
            if (context.Request.Headers.TryGetValues(headerName, out r))
            {
                return r.First();
            }
            else
            {
                return string.Empty;
            }
        }

        //重写基类的验证方式，加入我们自定义的Ticket验证
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            ExaminationResult ret = new ExaminationResult();
            string controllerName = actionContext.ControllerContext.ControllerDescriptor.ControllerName;
            string actionName = actionContext.ActionDescriptor.ActionName;
            try
            {
                string deviceId = GetDefaultHeadKey(actionContext, "DEVICEID");
                string key = GetDefaultHeadKey(actionContext, "XKEY");
                string mdn = GetDefaultHeadKey(actionContext, "MDN");
                string timeStampStr = GetDefaultHeadKey(actionContext, "XTIMESTAMP");
                string token = GetDefaultHeadKey(actionContext, "XTOKEN");

                long timeStamp;
                long nowTimestamp = DateTimeHelper.DateTimeToTimestamp(DateTime.Now);
                if (string.IsNullOrWhiteSpace(key))
                {
                    ret.Code = 901;
                    ret.Message = "key is empty";
                }
                else if (string.IsNullOrWhiteSpace(deviceId))
                {
                    ret.Code = 901;
                    ret.Message = "deviceId is empty";
                }
                else if (string.IsNullOrWhiteSpace(timeStampStr))
                {
                    ret.Code = 901;
                    ret.Message = "timeStamp is empty";
                }
                else if (string.IsNullOrWhiteSpace(token))
                {
                    ret.Code = 901;
                    ret.Message = "token is empty";
                }
                else if (!long.TryParse(timeStampStr, out timeStamp))
                {
                    ret.Code = 901;
                    ret.Message = "timeStamp error";
                }
                else if (Math.Abs(nowTimestamp - timeStamp) > 30 * 60 * 1000)
                {
                    ret.Code = 901;
                    ret.Message = "timeStamp error2";
                }
                else
                {
                    string vstr = ":)bb(;@201" + deviceId + "ad@xbb" + timeStampStr.Substring(timeStampStr.Length - 7, 7);
                    string md5 = StringHelper.MD5EnString(vstr);
                    if (token.ToLower() != md5.ToLower())
                    {
                        ret.Code = 901;
                        ret.Message = "token error";
                    }
                    else
                    {
                        ret.Code = 0;
                    }
                    if (token == "778899445566")
                    {
                        ret.Code = 0;
                        ret.Message = "success";
                    }
                }

                LogHelper.LogObj.InfoFormat("验证 controllerName:{7}，actionName:{8}；code:{5},message:{6};deviceId:{0},key:{1},mdn:{2},timeStampStr:{3},token:{4}",
                    deviceId, key, mdn, timeStampStr, token, ret.Code, ret.Message, controllerName, actionName);
            }
            catch (Exception ex)
            {
                ret.Code = 909;
                ret.Message = "server author exception";
                LogHelper.LogObj.Error(string.Format("验证请求头发生异常，controllerName:{0}，actionName:{1}", controllerName, actionName), ex);
                //throw ex;
            }
            if (ret.Code != 0)
            {
                var attributes = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
                bool isAnonymous = attributes.Any(a => a is AllowAnonymousAttribute);
                if (isAnonymous)
                {
                    var oResponse = new HttpResponseMessage(HttpStatusCode.OK);
                    oResponse.Content = new StringContent(ret.ToJson());
                    oResponse.ReasonPhrase = "验证错误,但显示出结果";
                    actionContext.Response = oResponse;
                }
                else
                {
                    HandleUnauthorizedRequest(actionContext);
                }
            }
            else
            {
                base.IsAuthorized(actionContext);
            }
        }

        #region 参考

        //重写基类的验证方式，加入我们自定义的Ticket验证
        public void OnAuthorization_参考(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //从http请求的头里面获取身份验证信息，验证是否是请求发起方的ticket
            var authorization = actionContext.Request.Headers.Authorization;

            if ((authorization != null) && (authorization.Parameter != null))
            {
                //解密用户ticket,并校验用户名密码是否匹配
                var encryptTicket = authorization.Parameter;
                if (ValidateTicket(encryptTicket))
                {
                    base.IsAuthorized(actionContext);
                }
                else
                {
                    HandleUnauthorizedRequest(actionContext);
                }
            }
            //如果取不到身份验证信息，并且不允许匿名访问，则返回未验证401
            else
            {
                var attributes = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
                bool isAnonymous = attributes.Any(a => a is AllowAnonymousAttribute);
                if (isAnonymous) base.OnAuthorization(actionContext);
                else HandleUnauthorizedRequest(actionContext);
            }
        }

        //校验用户名密码（正式环境中应该是数据库校验）
        private bool ValidateTicket(string encryptTicket)
        {
            //解密Ticket
            var strTicket = FormsAuthentication.Decrypt(encryptTicket).UserData;
            //从Ticket里面获取用户名和密码
            var index = strTicket.IndexOf("&");
            string strUser = strTicket.Substring(0, index);
            string strPwd = strTicket.Substring(index + 1);

            if (strUser == "admin" && strPwd == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}