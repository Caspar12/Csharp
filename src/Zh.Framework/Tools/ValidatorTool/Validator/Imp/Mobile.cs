using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Mobile : AbstractImp
    {
        public override bool Valid(object pObject)
        {
            if (pObject == null) return false;

            var mobilePhone = pObject.ToString();

            if (string.IsNullOrEmpty(mobilePhone)) return false;

            Regex regex = new Regex(@"^(1)\d{10}$");

            return regex.IsMatch(mobilePhone);
        }

        protected override string GetErrorMsgTpl()
        {
            return this.mILanguageTool.Get("{{FieldName}},Please enter the correct phone number ", "{{FieldName}}请输入正确的手机号码");
        }
    }
}
