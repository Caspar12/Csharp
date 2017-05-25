/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.MoneyTool
{
    public class MoneyToolImp : IMoneyTool
    {
        public string Format(object pMoney, int pFractionCount, FractionShowType pFractionShowType)
        {
            var dMoeny = Convert.ToDecimal(pMoney);
            var sMoney = dMoeny.ToString(string.Format("f{0}", pFractionCount));
            var arrMoney = sMoney.Split('.');
            var iMoney = arrMoney[0];
            string fMoney = string.Empty;
            if (arrMoney.Length > 1)
            {
                fMoney = arrMoney[1];
            }
            if (pFractionShowType == FractionShowType.Always)
            {
                return sMoney;
            }
            if (pFractionShowType == FractionShowType.No)
            {
                return arrMoney[0];
            }
            if (pFractionShowType == FractionShowType.Auto)
            {
                bool hasFraction = !string.IsNullOrEmpty(fMoney);
                if (hasFraction)
                {
                    var fractionDecimal = Convert.ToDecimal(arrMoney[1]);
                    if (fractionDecimal == 0)
                    {
                        return arrMoney[0];
                    }
                    else
                    {
                        return sMoney;
                    }
                }
                else
                {
                    return iMoney;
                }
            }
            return sMoney;
        }
        public string Format(object pMoney)
        {
            return Format(pMoney, 2, FractionShowType.Always);
        }
    }
}
