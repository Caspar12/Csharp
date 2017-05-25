using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class NotEmpty : AbstractImp
    {
        public override bool Valid(object pObject)
        {
            Empty emptyValidator = new Empty();
            this.Value = pObject;
            emptyValidator.Value = pObject;            
            return !emptyValidator.Valid(this.Value);
        }

        protected override string GetErrorMsgTpl()
        {
            return this.mILanguageTool.Get("{{FieldName}} can not be empty", "{{FieldName}}不能为空");
        }
    }
}
