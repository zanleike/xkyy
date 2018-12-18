using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FSLib.App.SimpleUpdater;
using System.Windows.Forms;
using Framework.Common;
using HursingManage.AL;

namespace NursingManage.Win
{
    class AppUpdater
    {
        static AppUpdater _Instance;
        public static AppUpdater Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AppUpdater();
                }
                return _Instance;
            }
        }

        Updater _updater;

        private AppUpdater()
        {
            try
            {
                string url = AppConfig.AppSettings.AppUpdaterUrl;
                _updater = Updater.CreateUpdaterInstance(url + "/{0}", "update_c.xml");
                _updater.Error += (s, e) =>
                {
                    LogHelper.LogObj.Error("更新发生了错误", _updater.Context.Exception);
                };
                _updater.UpdatesFound += (s, e) =>
                {
                    //MessageBox.Show("发现了新版本：" + _updater.Context.UpdateInfo.AppVersion);
                };
                _updater.NoUpdatesFound += (s, e) =>
                {
                    //MessageBox.Show("没有新版本！");
                };
                _updater.MinmumVersionRequired += (s, e) =>
                {
                    LogHelper.LogObj.Error("自动更新时，当前版本过低无法使用自动更新");
                };
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("创建升级对象失败!", ex);
                //MessageBox.Show("创建升级对象失败!");
            }
        }
        public bool CheckUpdate()
        {
            if (_updater == null)
            {
                LogHelper.LogObj.Error("未配置在线升级!");
                return false;
            }
            try
            {
                bool r = _updater.BeginCheckUpdateInProcess();
                return r;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("执行检查更行命令出错!", ex);
                return false;
            }
        }
    }
}
