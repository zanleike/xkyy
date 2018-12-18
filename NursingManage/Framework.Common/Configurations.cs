/*
    创建日期: 2013.9.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2015.1.23   增加设置配置项的方法
        2016.8.30   GetConnectString 判断得到的连接字符串是否为空
 */
using System.Configuration;

namespace Framework.Common
{
    /// <summary>
    /// 读取与设置当前程序配置项的静态类
    /// </summary>
    public class Configurations
    {
        /// <summary>
        /// 
        /// </summary>
        public static string FTPUrl { get; set; }

        /// <summary>
        /// 获得指定key的连接字符串
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string GetConnectString(string keyName)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings[keyName];
            if (conn == null) return string.Empty;
            return conn.ConnectionString;
        }
        /// <summary>
        /// 设置连接字符串
        /// </summary>
        /// <param name="keyName">连接字符串名称</param>
        /// <param name="value">连接字符串值</param>
        public static void SetConnectString(string keyName, string value)
        {
            //新建一个连接字符串实例  
            ConnectionStringSettings mySettings = new ConnectionStringSettings(keyName, value);
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.ConnectionStrings[keyName] != null)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(keyName);
            }
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节(注意大小写)
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        /// <summary>
        /// 获得指定key的配置项
        /// </summary>
        public static string GetAppSettings(string keyName)
        {
            string configValue = ConfigurationManager.AppSettings[keyName];
            return configValue;
        }
        /// <summary>
        /// 设置一个配置项
        /// </summary>
        /// <param name="keyName">配置项名</param>
        /// <param name="value">配置项值</param>
        public static void SetAppSettings(string keyName, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.AppSettings[keyName] != null)
            {
                config.AppSettings.Settings.Remove(keyName);
            }
            config.AppSettings.Settings.Add(keyName, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}