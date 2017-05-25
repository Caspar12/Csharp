/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public class Equal : AbstractImp
    {
        public string FieldName2 { get; set; }
        public object EqualsToObject { get; set; }
        public override bool Valid(object pObject)
        {
            return pObject.Equals(EqualsToObject);
        }

        protected override string GetErrorMsgTpl()
        {
            return this.mILanguageTool.Get("{{FieldName}} must be equals {{FieldName2}}", "{{FieldName}}必须等于{{FieldName2}}");
        }
    }
}
