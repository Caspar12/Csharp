using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Empty : AbstractImp
    {
        public override bool Valid(object pObject)
        {
            if (pObject == null)
            {
                return true;
            }
            if (pObject.GetType() == typeof(String))
            {
                return string.IsNullOrEmpty(pObject.ToString());
            }
            if (pObject is ICollection)
            {
                var i = (ICollection)pObject;
                return i.Count <= 0;
            }

            return pObject == null;
        }

        protected override string GetErrorMsgTpl()
        {
            return this.mILanguageTool.Get("{{FieldName}} must be empty", "{{FieldName}}必须为空");
        }
    }
}
