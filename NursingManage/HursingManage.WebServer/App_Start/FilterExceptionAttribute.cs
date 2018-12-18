using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Framework.Common;

namespace HursingManage.WebServer.App_Start
{
    public class FilterExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var isAjax = filterContext.HttpContext.Request.IsAjaxRequest();
            if (isAjax)
            {
                filterContext.Result = new ContentResult
                {
                    Content =
                        JsonConvert.SerializeObject(
                            new { Code = 909, Message = filterContext.Exception.Message})
                };
            }
            LogHelper.LogObj.Error("服务器发生异常。", filterContext.Exception);
            //if (!(filterContext.Exception is ShowException))
            //{
            //    WriteLog(filterContext);
            //}
            filterContext.ExceptionHandled = true;
        }

        private Exception BuildErrorMessage(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }

        private void WriteLog(ExceptionContext filterContext)
        {
            var httpContext = filterContext.RequestContext.HttpContext.Request;
            var ex = BuildErrorMessage(filterContext.Exception);
            // 在出现未处理的错误时运行的代码
            StringBuilder _builder = new StringBuilder();
            _builder.Append("\r\n-------------  异常信息   ---------------------------------------------------------------");
            _builder.Append("\r\n发生时间：" + DateTime.Now.ToString());
            _builder.Append("\r\n发生异常页：" + httpContext.Url.ToString());
            _builder.Append("\r\n异常信息：" + ex.Message);
            _builder.Append("\r\n错误源：" + ex.Source);
            _builder.Append("\r\n堆栈信息：" + ex.StackTrace);
            _builder.Append("\r\n-----------------------------------------------------------------------------------------\r\n");
            //日志物理路径

            DateTime date = DateTime.Now;
            string path = httpContext.MapPath("~/Log/");
            string month = date.ToString("yyyy-MM");
            if (!System.IO.Directory.Exists(path + month))
                System.IO.Directory.CreateDirectory(path + month);
            string currentDate = date.ToString("yyyy-MM-dd");
            string savePath = path + month + "/" + currentDate + ".log";
            System.IO.File.AppendAllText(savePath, _builder.ToString(), System.Text.Encoding.Default);
            //filterContext.RequestContext.HttpContext.Server.ClearError();
            //filterContext.ExceptionHandled = true;

            //filterContext.RequestContext.HttpContext.Response.Redirect("/Home/Error");
        }
    }
}