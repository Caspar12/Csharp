/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.LanguageTool;

namespace Zh.Framework.Tools.ValidatorTool.Validator.Imp
{
    public abstract class AbstractImp : IValidator
    {
        protected ILanguageTool _ILanguageTool;
        protected ILanguageTool mILanguageTool
        {
            get
            {
                if (_ILanguageTool == null)
                {
                    _ILanguageTool = ToolFactory.CreateILanguageTool();
                }
                return _ILanguageTool;
            }
        }


        protected virtual string GetErrorFieldMsg()
        {
            return GetErrorMsgTpl().Replace("{FieldName}", FieldName);
        }
        protected virtual string GetErrorMsg()
        {
            if (!string.IsNullOrEmpty(ErrorMsg))
            {
                return ErrorMsg;
            }
            return GetErrorFieldMsg();
        }

        protected abstract string GetErrorMsgTpl();

        public object Value { get; set; }
        public string ErrorMsg { get; set; }
        public string FieldName { get; set; }
        public abstract bool Valid(object pObject);
        public virtual Entities.ExecResult IsValid()
        {
            var isValid = Valid(this.Value);
            return new Entities.ExecResult()
            {
                Success = isValid,
                Message = isValid ? "验证通过" : GetErrorMsg(),
            };
        }
    }
}
