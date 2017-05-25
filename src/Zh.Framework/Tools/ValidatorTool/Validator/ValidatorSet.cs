/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.Framework.Tools.ValidatorTool.Validator
{
   public class ValidatorSet
   {
      public ValidatorSet()
      {
         this.IValidators = new List<IValidator>();
      }
      public ExecResult IsValid()
      {
         if (this.IValidators == null || this.IValidators.Count == 0)
         {
            return new ExecResult()
            {
               Code = 1,
               Success = true,
               Message = "验证通过"
            };
         }

         List<ExecResult> tAllValidResultList = new List<ExecResult>(IValidators.Count);
         ExecResult tFirstValidFalse = null;
         foreach (var tIValidators in IValidators)
         {
            var result = tIValidators.IsValid();
            tAllValidResultList.Add(result);
            if (!result.Success && tFirstValidFalse == null)
            {
               tFirstValidFalse = result;
            }
         }

         return new ExecResult()
         {
            Code = tFirstValidFalse == null ? 1 : -1,
            Success = tFirstValidFalse == null,
            Message = tFirstValidFalse == null ? "验证通过" : tFirstValidFalse.Message,
            Data = tAllValidResultList
         };
      }

      public List<IValidator> IValidators { get; set; }
   }
}
