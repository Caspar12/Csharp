using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Helpers
{
    public class DateTimeHelper
    {
        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">Unix时间</param>
        /// <returns>DateTime</returns>
        public static System.DateTime UnixToDateTime(long d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            return time;
        }
        /// <summary>
        /// 将DateTime类型时间转换为16进制Unix时间戳
        /// </summary>
        /// <param name="d">16进制Unix时间</param>
        /// <returns>DateTime</returns>
        public static string DateTimeToUnix16(DateTime time)
        {
            var unixTime = DateTimeToUnix(time);

            var unixTime16 = Convert.ToString(unixTime, 16);
            return unixTime16;
        }
        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>long</returns>
        public static long DateTimeToUnix(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (long)(time - startTime).TotalSeconds;
            return t;
        }
    }
}
