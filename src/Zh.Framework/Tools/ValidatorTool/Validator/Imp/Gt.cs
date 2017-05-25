/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Gt : AbstractImp
    {
        public object Min { get; set; }
        public override bool Valid(object pObject)
        {
            var tIValidatorTool = ToolFactory.CreateIValidatorTool();
            var tIProgramTool = ToolFactory.CreateIProgramTool();

            if (tIProgramTool.IsStringType(pObject))
            {
                if (tIValidatorTool.IsEmpty(pObject))
                {
                    return false;
                }
                else
                {
                    var objString = pObject.ToString();
                    var decMin = Convert.ToDecimal(Min);
                    if (objString.Length > decMin)
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
                var decMin = Convert.ToDecimal(Min);
                return decObj > decMin;
            }
            if (tIProgramTool.IsDateTimeType(pObject))
            {
                if (Min == null)
                {
                    return true;
                }
                if (pObject == null)
                {
                    return false;
                }
                DateTime dObj = Convert.ToDateTime(pObject);
                DateTime dMin = Convert.ToDateTime(Min);

                return dObj > dMin;
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
                enSb.AppendFormat("{{FieldName}} must be greater than {0}", this.Min);
                zhSb.AppendFormat("{{FieldName}}必须大于{0}", this.Min);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsStringType(Value))
            {
                enSb.AppendFormat("{{FieldName}} length must be greater than {0}", this.Min);
                zhSb.AppendFormat("{{FieldName}}长度必须大于{0}", this.Min);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsDateTimeType(Value))
            {
                var dMinString = ToolFactory.CreateICalenderTool().Format(Min);
                enSb.AppendFormat("{{FieldName}} must be greater than {0}", dMinString);
                zhSb.AppendFormat("{{FieldName}}必须大于{0}", dMinString);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            throw new Exception("无法自动检测比较类型");
        }
    }
}
