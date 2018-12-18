/*
 date:  2017.3.7
 author:张存
 email: zhangcunliang@126.com
 update logs:
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using Framework.Common;
using System.Text;
using HursingManage.AL;
using Framework.Common.Helpers;

namespace NursingManage.Win
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{4DAAC4ED-8D84-4645-82E9-8BCA3B45936F}");

        /// <summary>
        /// 程序运行前的初始化
        /// </summary>
        public static bool RunBeforeInitialize()
        {
            //TODO:程序运行时判断服务器时间与本地时间是否一致，请修改为正确的时间            
            //if (lastLoginTime > DateTime.Now)
            //{
            //    MessageBox.Show("系统检测出当前计算机时间出现异常,点击确定程序将退出");
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AppConfig.AppSettings.MoreOpen)
            {
                string mutexName = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "");
                mutex = new Mutex(true, mutexName);
            }
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("在同一时间只能运行一个软件!");
                return;
            }
            try
            {
                //处理未捕获的异常
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常  
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                //处理非UI线程异常  
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (!RunBeforeInitialize())
                {
                    Application.Exit();
                    return;
                }
                //检查更新
                AppUpdater.Instance.CheckUpdate();

                if (AppConfig.AppSettings.IsExamination)
                {
                    Application.Run(new FrmExamination());
                }
                else
                {
                    if (new FrmLogin().ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = string.Empty;
                string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
                if (ex != null)
                {
                    WriteUnhandledExceptionLogs("出现应用程序未处理的异常", ex);
                }
                else
                {
                    WriteUnhandledExceptionLogs("应用程序线程错误,exception is null");
                }
                MessageBox.Show("出现应用程序未处理的异常，请及时联系维护人员！\r\n" + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 写未捕获的异常
        /// </summary>
        /// <param name="errMsg"></param>
        static void WriteUnhandledExceptionLogs(string errMsg)
        {
            WriteUnhandledExceptionLogs(errMsg, null);
            //LogHelper.LogObj.Fatal(errMsg);

        }
        static void WriteUnhandledExceptionLogs(string errMsg, Exception ex)
        {
            if (ex == null)
            {
                LogHelper.LogObj.Fatal(errMsg);
            }
            else
            {
                LogHelper.LogObj.Fatal(errMsg, ex);
            }
            WriteDBLog(errMsg, ex);
        }

        static void WriteDBLog(string errMsg, Exception ex)
        {
            try
            {
                ALCommon.Instance.WriteDBLog("***" + errMsg);
            }
            catch (Exception e)
            {
                LogHelper.LogObj.Fatal("将错误日志写入数据库中发生异常", e);
            }
        }

        /// <summary>
        /// 做法很多，可以是把出错详细信息记录到文本、数据库，发送出错邮件到作者信箱或出错后重新初始化等等         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = "";
            string strDateInfo = "②出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            Exception error = e.Exception as Exception;
            if (error != null)
                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n", error.GetType().Name, error.Message, error.StackTrace);
            else
                str = string.Format("应用程序线程错误:{0}", e);
            WriteUnhandledExceptionLogs(str);
            MessageBox.Show("UI线程发生未处理异常，请及时联系技术人员！\r\n" + error.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            Exception error = e.ExceptionObject as Exception;
            string strDateInfo = "③出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            if (error != null) str = string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆栈信息:{1}", error.Message, error.StackTrace);
            else str = string.Format("Application UnhandledError:{0}", e);
            WriteUnhandledExceptionLogs(str);
            MessageBox.Show("非UI线程未处理异常，请停止当前操作并及时联系技术人员！\r\n" + error.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}