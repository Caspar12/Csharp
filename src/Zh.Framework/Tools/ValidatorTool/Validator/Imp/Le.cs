/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Le : AbstractImp
    {
        public object Max { get; set; }

        public override bool Valid(object pObject)
        {
            var equalValidator = new Equal();
            var ltValidator = new Lt();

            equalValidator.Value = Max;
            ltValidator.Max = Max;

            return equalValidator.Valid(pObject) || ltValidator.Valid(pObject);
        }
        protected override string GetErrorMsgTpl()
        {
            StringBuilder enSb = new StringBuilder();
            StringBuilder zhSb = new StringBuilder();
            var tIProgramTool = ToolFactory.CreateIProgramTool();
            if (tIProgramTool.IsNumericType(this.Value))
            {
                enSb.AppendFormat("{{FieldName}} must be less than or equal to {0}", this.Max.ToString());
                zhSb.AppendFormat("{{FieldName}}必须少于或等于{0}", this.Max.ToString());
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsStringType(Value))
            {
                enSb.AppendFormat("{{FieldName}} length must be less than or equal to {0}", this.Max.ToString());
                zhSb.AppendFormat("{{FieldName}}长度必须少于或等于{0}", this.Max.ToString());
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsDateTimeType(Value))
            {
                var dMaxString = ToolFactory.CreateICalenderTool().Format(this.Max);
                enSb.AppendFormat("{{FieldName}} must be less than or equal to {0}", dMaxString);
                zhSb.AppendFormat("{{FieldName}}必须少于或等于{0}", dMaxString);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            throw new Exception("无法自动检测比较类型");
        }
    }


}
