/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.CalenderTool
{
    public class CalenderToolImp : ICalenderTool
    {
        public string Format(object pDateTime)
        {
            if (pDateTime == null)
            {
                return "";
            }
            var dateTime = Convert.ToDateTime(pDateTime);
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
