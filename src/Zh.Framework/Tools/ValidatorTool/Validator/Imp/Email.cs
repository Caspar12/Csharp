using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Email : AbstractImp
    {
        public override bool Valid(object pObject)
        {
            if (pObject == null) return false;

            var email = pObject.ToString();

            if (string.IsNullOrEmpty(email)) return false;

            Regex regex = new Regex(@"^([a-zA-Z0-9]|[._])+@([a-zA-Z0-9_-])+([\.a-zA-Z0-9_-])+$");

            return regex.IsMatch(email);
        }

        protected override string GetErrorMsgTpl()
        {
            return this.mILanguageTool.Get("{{FieldName}},Please enter the correct e-mail ", "{{FieldName}}请输入正确的邮箱地址");
        }
    }
}
