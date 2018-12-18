/*
    创建日期: 2016.7.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
 */
using System.Collections.Generic;
using Framework.Common.Helpers;

namespace Framework.Common
{
    public class AppConfigBase<T> where T : class,new()
    {
        T _Config;
        public T LoadConfigItem()
        {
            _Config = new T();
            string[] configKeys = ReflectionHelper.GetPropertyNames(_Config.GetType());
            Dictionary<string, object> configItems = new Dictionary<string, object>();
            foreach (var key in configKeys)
            {
                string v = Configurations.GetAppSettings(key);
                configItems.Add(key, v);
            }

            ReflectionHelper.SetPropertyValue(_Config, configItems);
            return _Config;
        }
        /// <summary>
        /// 程序标题
        /// </summary>
        public string AppCaption { get; protected set; }
        /// <summary>
        /// 运行一个实例的模式
        /// 0:只运行1个,1:一个目录只运行1个
        /// </summary>
        public int OnlyRunOneMode { get; protected set; }
        /// <summary>
        /// 在线升级模式
        /// 0:不启用,1:软件启动时提示,2:菜单手动
        /// </summary>
        public int AppUpdaterMode { get; protected set; }
        /// <summary>
        /// 升级url地址
        /// </summary>
        public string AppUpdaterUrl { get; protected set; }
    }
}