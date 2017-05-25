/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.Framework.Tools.ValidatorTool.Validator.NVCollectionValidator
{
   public interface IValidatorChain : IFieldChain
   {
      IValidatorChain NotEmpty();
      IValidatorChain NotEmpty(string pErrorMsg);
      IValidatorChain Ge(object pMin);
      IValidatorChain Ge(object pMin, string pErrorMsg);
      IValidatorChain Gt(object pMin);
      IValidatorChain Gt(object pMin, string pErrorMsg);
      IValidatorChain Le(object pMax);
      IValidatorChain Le(object pMax, string pErrorMsg);
      IValidatorChain Lt(object pMax);
      IValidatorChain Lt(object pMax, string pErrorMsg);
      IValidatorChain Equal(string pEqualsToName, string pEqualsToFieldName);
      IValidatorChain Equal(string pEqualsToName, string pEqualsToFieldName, string pErrorMsg);
   
   }
}
