/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.CalenderTool
{
    public interface ICalenderTool
    {
        /// <summary>
        /// 格式化 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="pDateTime">时间</param>
        /// <returns>时间格式化字符串</returns>
        string Format(object pDateTime);
    }
}
