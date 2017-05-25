using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool;

namespace Zh.Test.Console
{
  public  class Kp :IValidatorTool
    {
        public bool IsEmpty(object pObject)
        {
            throw new NotImplementedException();
        }

        public bool IsNotEmpty(object pObject)
        {
            throw new NotImplementedException();
        }

        public bool IsExpire(DateTime? expire)
        {
            throw new NotImplementedException();
        }

        public Framework.Tools.ValidatorTool.Validator.NVCollectionValidator.IFieldChain CreateNVValidator(System.Collections.Specialized.NameValueCollection pNameValueCollection)
        {
            throw new NotImplementedException();
        }
    }
}
