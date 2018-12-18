/*
    创建日期: 2013.6.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2014.12.5 修改写日志指定文件夹
        2015.1.22 指定从配置文件中去日志的缺省路径,因为bs项目不允许访问bin文件夹
        2015.2.9  日志中加入log4net,这里从单独配置文件中获取各参数
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using log4net;

namespace Framework.Common
{
    /// <summary>
    /// 日志的相关操作
    /// </summary>
    public class LogHelper
    {
        static string _RootLogPath = "Logs";

        static string RootLogPath
        {
            get
            {
                //string r = Configurations.GetAppSettings("DefaultLogPath");
                //return r;
                return _RootLogPath;
            }
        }
        public static void SetRootLogPath(string rootPath)
        {
            _RootLogPath = rootPath;
        }

        /// <summary>
        /// 写日志,指定文件夹写日志内容
        /// </summary>
        /// <param name="folder">文件夹</param>
        /// <param name="logContent">日志内容</param>
        public static void WriteLog(string folder, string logContent)
        {
            if (!string.IsNullOrEmpty(folder))
            {
                folder = RootLogPath + "/" + folder;
            }
            else
            {
                folder = RootLogPath;
            }
            folder = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + folder;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string logFile = folder + "/" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            using (StreamWriter sw = new StreamWriter(logFile, true))
            {
                sw.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "]:" + logContent);
                sw.Close();
            }
        }
        /// <summary>
        /// 写日志,指定文件夹写日志内容,默认路径是:Log文件夹
        /// </summary>
        /// <param name="logContent">日志内容</param>
        public static void WriteLog(string logContent)
        {
            WriteLog(string.Empty, logContent);
        }

        static ILog _LogObj;
        /// <summary>
        /// log4net方式的记录日志
        /// 如果需要捕获到具体的方法及代码行,需要直接使用Ilog,而不能分支出来的方法
        /// web项目使用,需要在 AssemblyInfo.cs 配置　[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]        
        /// </summary>
        public static ILog LogObj
        {
            // 1. web项目使用,需要在 AssemblyInfo.cs 配置　[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
            // 2. Global 里的 Application_Start 方法加入 log4net.Config.XmlConfigurator.Configure();
            // 3. <configSections>
            //      <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
            //    </configSections>  
            // 4.将log4net.config 放置网站跟目录
            get
            {
                if (_LogObj == null)
                {
                    //string fileName = Configurations.GetAppSettings("log4netConfigFile");
                    ////如果当前配置中没有配置log4net配置文件,则以默认log4net.config来载入
                    //if (string.IsNullOrEmpty(fileName))
                    //{
                    //    fileName = "log4net.config";
                    //}
                    //FileInfo log4NetConfigFile = new FileInfo(fileName);
                    //log4net.Config.XmlConfigurator.Configure(log4NetConfigFile);
                    string loggerName = Configurations.GetAppSettings("log4netLoggerName");
                    if (string.IsNullOrEmpty(loggerName))
                    {
                        loggerName = "Default";
                    }

                    _LogObj = GetLog4Net(loggerName);
                }
                return _LogObj;
            }
        }

        public static ILog GetLog4Net(string loggerName)
        {
            string fileName = Configurations.GetAppSettings("log4netConfigFile");
            //如果当前配置中没有配置log4net配置文件,则以默认log4net.config来载入
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "log4net.config";
            }
            FileInfo log4NetConfigFile = new FileInfo(fileName);
            log4net.Config.XmlConfigurator.Configure(log4NetConfigFile);
            ILog log = LogManager.GetLogger(loggerName);
            return log;
        }
    }
}