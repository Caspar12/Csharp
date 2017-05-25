/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;

using System.Text;

namespace Zh.Framework.Tools.MoneyTool
{
    /// <summary>
    /// 小数显示模式
    /// </summary>
    public enum FractionShowType
    {
        /// <summary>
        /// 总是显示
        /// </summary>
        Always = 0,
        /// <summary>
        /// 不显示
        /// </summary>
        No = 1,
        /// <summary>
        /// 自动显示,有小数部分显示,没有则不显示
        /// </summary>
        Auto = 2
    }
}
