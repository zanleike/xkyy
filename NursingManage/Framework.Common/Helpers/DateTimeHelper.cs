using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// 获取当前时间的委托
    /// </summary>
    public delegate DateTime DateTimeHandle();

    public class DateTimeHelper
    {

        static DateTimeHandle _GetNowTimeHandle;
        /// <summary>
        /// 注册获取当前时间的委托方法
        /// </summary>
        public static void RegisterGetCurrentTimeHandle(DateTimeHandle dtHdl)
        {
            _GetNowTimeHandle = dtHdl;
        }
        /// <summary>
        /// 获取当前时间,执行之前必须先注册获取当前时间的委托,
        /// 如果未注册当前获取时间的委托方法,那么则返回本地时间
        /// </summary>
        public static DateTime GetCurrentTime()
        {
            if (_GetNowTimeHandle == null)
            {
                return DateTime.Now;
            }
            return _GetNowTimeHandle();
        }

        System.Timers.Timer _Timer;
        public delegate void TimerDelegate();
        /// <summary>
        /// 计时方法,
        /// 判断某操作超时的方法
        /// </summary>
        /// <param name="intTime">即使毫秒数</param>
        /// <param name="timerFunc">到时间后触发的方法</param>
        public void StartTimer(int intTime, TimerDelegate timerFunc)
        {
            if (_Timer == null)
            {
                _Timer = new System.Timers.Timer();//实例化Timer类
                //到达时间的时候执行事件；
                _Timer.Elapsed += new System.Timers.ElapsedEventHandler(delegate(object sender, System.Timers.ElapsedEventArgs e)
                    {
                        timerFunc();
                    });
            }
            _Timer.Interval = intTime;//设置间隔时间，为毫秒；
            _Timer.AutoReset = false;//设置是执行一次（false）还是一直执行(true)；
            _Timer.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；            
        }

        /// <summary>
        /// 将时间格式化成只有日期的形式输出
        /// </summary>
        /// <param name="sourceDate">要转换的时间</param>        
        /// <param name="addDay">源时间增加的天数</param>
        /// <returns></returns>
        public static DateTime DateTimeFormatDate(DateTime sourceDate, int addDay)
        {
            return Convert.ToDateTime(sourceDate.AddDays(addDay).ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// 将时间格式化成只有日期的形式输出
        /// </summary>
        /// <param name="sourceDate">要转换的时间</param>
        /// <returns></returns>
        public static DateTime DateTimeFormatDate(DateTime sourceDate)
        {
            return DateTimeFormatDate(sourceDate, 0);
        }

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

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式,从1970.1.1 到当前时间的毫秒
        /// </summary>
        /// <param name="time"> DateTime时间格式</param>
        /// <returns>Unix时间戳格式(毫秒)</returns>
        public static long DateTimeToTimestamp(DateTime time)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (long)(time - startTime).TotalMilliseconds;
        }
        /// <summary>
        /// 时间戳转换为时间
        /// </summary>
        /// <param name="timeStamp">时间戳（毫秒）</param>
        public static DateTime GetTimeByTimestamp(long timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            return dtStart.AddMilliseconds(timeStamp);
        }

        /// <summary>
        /// 根据日期获得星期，返回 日、一、二、三、四、五、六
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetWeekDay(DateTime dt)
        {
            string[] Day = new string[] { "日", "一", "二", "三", "四", "五", "六" };
            string week = Day[Convert.ToInt32(dt.DayOfWeek.ToString("d"))].ToString();
            return week;
        }

        public static bool IsDateTime(string timeStr)
        {   
            DateTime dtDate;
            return DateTime.TryParse(timeStr, out dtDate);
        }
    }
}
