using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// 有相关操作系统Api的封装类
    /// </summary>
    public class SysApiHelper
    {
        #region 设置系统时间

        [StructLayoutAttribute(LayoutKind.Sequential)]
        class SystemTime
        {
            public ushort vYear;
            public ushort vMonth;
            public ushort vDayOfWeek;
            public ushort vDay;
            public ushort vHour;
            public ushort vMinute;
            public ushort vSecond;
        }

        [DllImportAttribute("Kernel32.dll")]
        static extern void GetLocalTime(SystemTime st);

        [DllImportAttribute("Kernel32.dll")]
        static extern void SetLocalTime(SystemTime st);
        /// <summary>
        /// 通过api获取本地时间
        /// </summary>
        /// <returns>返回c#时间类型</returns>
        public static DateTime GetLocalTime()
        {
            SystemTime sysTime = new SystemTime();
            GetLocalTime(sysTime);
            DateTime dt = new DateTime(sysTime.vYear, sysTime.vMonth, sysTime.vDay, sysTime.vHour, sysTime.vMinute, sysTime.vSecond);
            return dt;
        }
        /// <summary>
        /// 根据c#时间类型设置本地时间
        /// </summary>
        public static bool SetLocalTime(DateTime dt)
        {
            SystemTime sysTime = new SystemTime();
            sysTime.vYear = (ushort)dt.Year;
            sysTime.vMonth = (ushort)dt.Month;
            sysTime.vDay = (ushort)dt.Day;
            sysTime.vHour = (ushort)dt.Hour;
            sysTime.vMinute = (ushort)dt.Minute;
            sysTime.vSecond = (ushort)dt.Second;
            SetLocalTime(sysTime);
            return true;
        }

        #endregion
    }
}
