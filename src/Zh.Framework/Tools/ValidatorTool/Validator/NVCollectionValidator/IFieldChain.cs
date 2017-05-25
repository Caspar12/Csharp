using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.Framework.Tools.ValidatorTool.Validator.NVCollectionValidator
{
   public interface IFieldChain
   {
      IValidatorChain SetField(string pName, Type pValueType, string pFieldName);
      IValidatorChain SetField(string pName, Type pValueType);
      ExecResult IsValid();
   }
}
