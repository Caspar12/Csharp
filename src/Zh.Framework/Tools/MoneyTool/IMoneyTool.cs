/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;

using System.Text;

namespace Zh.Framework.Tools.MoneyTool
{
    public interface IMoneyTool
    {
        /// <summary>
        /// 格式化,保留pFractionCount个小数,pFractionShowType小数显示模式
        /// </summary>
        /// <param name="pMoney">金钱</param>
        /// <param name="pFractionCount">保留小数位数</param>
        /// <param name="pFractionShowType">小数显示模式</param>
        /// <returns>格式化金钱字符串</returns>
        string Format(object pMoney, int pFractionCount, FractionShowType pFractionShowType);
        /// <summary>
        /// 格式化,保留2个小数,总是显示小数
        /// </summary>
        /// <param name="pMoney">金钱</param>
        /// <returns>格式化金钱字符串</returns>
        string Format(object pMoney);
    }
}
