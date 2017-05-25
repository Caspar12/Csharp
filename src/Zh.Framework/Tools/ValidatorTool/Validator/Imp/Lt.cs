/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Lt : AbstractImp
    {
        public object Max { get; set; }
        public override bool Valid(object pObject)
        {
            var tIValidatorTool = ToolFactory.CreateIValidatorTool();
            var tIProgramTool = ToolFactory.CreateIProgramTool();
            if (tIProgramTool.IsStringType(pObject))
            {
                if (tIValidatorTool.IsEmpty(pObject))
                {
                    return true;
                }
                else
                {
                    var objString = pObject.ToString();
                    var decMax = Convert.ToDecimal(Max);
                    if (objString.Length < decMax)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (tIProgramTool.IsNumericType(pObject))
            {
                decimal decObj = Convert.ToDecimal(pObject);
                var decMax = Convert.ToDecimal(Max);
                return decObj < decMax;
            }
            if (tIProgramTool.IsDateTimeType(pObject))
            {
                if (Max == null)
                {
                    return true;
                }
                if (pObject == null)
                {
                    return false;
                }
                DateTime dObj = Convert.ToDateTime(pObject);
                DateTime dMax = Convert.ToDateTime(Max);

                return dObj < dMax;
            }
            throw new Exception("无法自动检测比较类型");
        }
        protected override string GetErrorMsgTpl()
        {
            StringBuilder enSb = new StringBuilder();
            StringBuilder zhSb = new StringBuilder();
            var tIProgramTool = ToolFactory.CreateIProgramTool();
            if (tIProgramTool.IsNumericType(this.Value))
            {
                enSb.AppendFormat("{{FieldName}} must be less than {0}", this.Max);
                zhSb.AppendFormat("{{FieldName}}必须少于{0}", this.Max);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsStringType(Value))
            {
                enSb.AppendFormat("{{FieldName}} length must be less than {0}", this.Max);
                zhSb.AppendFormat("{{FieldName}}长度必须少于{0}", this.Max);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsDateTimeType(Value))
            {
                var dMaxString = ToolFactory.CreateICalenderTool().Format(Max);
                enSb.AppendFormat("{{FieldName}} must be less than {0}", dMaxString);
                zhSb.AppendFormat("{{FieldName}}必须少于{0}", dMaxString);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            throw new Exception("无法自动检测比较类型");
        }
    }
}
