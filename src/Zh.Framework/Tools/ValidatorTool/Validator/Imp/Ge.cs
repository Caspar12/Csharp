/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Ge : AbstractImp
    {
        public object Min { get; set; }

        public override bool Valid(object pObject)
        {
            var equalValidator = new Equal();
            var gtValidator = new Gt();

            equalValidator.Value = Min;
            gtValidator.Min = Min;

            return equalValidator.Valid(pObject) || gtValidator.Valid(pObject);
        }

        protected override string GetErrorMsgTpl()
        {
            StringBuilder enSb = new StringBuilder();
            StringBuilder zhSb = new StringBuilder();
            var tIProgramTool = ToolFactory.CreateIProgramTool();
            if (tIProgramTool.IsNumericType(this.Value))
            {
                enSb.AppendFormat("{{FieldName}} must be greater than or equal to {0}", this.Min);
                zhSb.AppendFormat("{{FieldName}}必须大于或等于{0}", this.Min);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsStringType(Value))
            {
                enSb.AppendFormat("{{FieldName}} length must be greater than or equal to {0}", this.Min);
                zhSb.AppendFormat("{{FieldName}}长度必须大于或等于{0}", this.Min);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            if (tIProgramTool.IsDateTimeType(Value))
            {
                var dMinString = ToolFactory.CreateICalenderTool().Format(this.Min);
                enSb.AppendFormat("{{FieldName}} must be greater than or equal to {0}", dMinString);
                zhSb.AppendFormat("{{FieldName}}必须大于或等于{0}", dMinString);
                return this.mILanguageTool.Get(enSb.ToString(), zhSb.ToString());
            }
            throw new Exception("无法自动检测比较类型");
        }
    }
}
