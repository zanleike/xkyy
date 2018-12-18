using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Common;

namespace HursingManage.AL
{
    public class AppConfig : AppConfigBase<AppConfig>
    {
        static AppConfig C;
        public static AppConfig AppSettings
        {
            get
            {
                if (C == null)
                {
                    C = new AppConfig();
                    C = C.LoadConfigItem();
                }
                return C;
            }
        }
        /// <summary>
        /// 连接字符串是否加密
        /// </summary>
        public bool ConnStringEncrypt { set; get; }
        /// <summary>
        /// 是否考试系统
        /// </summary>
        public bool IsExamination { set; get; }
        /// <summary>
        /// 是否允许同时打开多个程序
        /// </summary>
        public bool MoreOpen { set; get; }
    }
}
