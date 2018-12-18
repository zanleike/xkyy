using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using ZhCun.Framework.Common;

namespace ZCJH.HursingManage.WebServer.App_Start
{
    public class ExaminationFilterAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //LogHelper.LogObj.InfoFormat("ExaminationFilterAttribute.OnActionExecuting");

            //var a = actionContext.Request.Headers.GetValues("token");
            ////ctionContext.Request.Headers.
            //foreach (var item in a)
            //{
            //    LogHelper.LogObj.InfoFormat("token:{0}", item);
            //}

            //var oResponse = new HttpResponseMessage(HttpStatusCode.OK);
            //oResponse.Content = new StringContent("方法不被支持");
            //oResponse.ReasonPhrase = "This Func is Not Supported";
            //actionContext.Response = oResponse;

            base.OnActionExecuting(actionContext);
        }

        //该方法会在action方法执行之前调用  
        //public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        //{
        //    filterContext.HttpContext.Response.Write("我是OnActionExecuting，我在action方法调用钱执行<br/>");
        //    var a  =filterContext.RequestContext.HttpContext.Request.Headers.Get("token");

        //    if (string.IsNullOrWhiteSpace(a))
        //    {
        //        var oResponse = new HttpResponseMessage(HttpStatusCode.OK);
        //        oResponse.Content = new StringContent("方法不被支持");
        //        oResponse.ReasonPhrase = "This Func is Not Supported";
        //        filterContext。
        //        actionExecutedContext.Response = oResponse;
        //    }

        //    base.OnActionExecuting(filterContext);
        //}
        ////该方法会在action方法执行之前调用  
        //public override void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext)
        //{
        //    base.OnActionExecuted(filterContext);
        //}

    }
}