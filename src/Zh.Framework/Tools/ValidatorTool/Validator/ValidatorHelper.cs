/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool.Validator.Imp;

namespace Zh.Framework.Tools.ValidatorTool.Validator
{
   public static class ValidatorHelper
   {
      static IValidator Empty(object pValue, string pFieldName, string pErrorMsg)
      {
         IValidator validator = new Empty()
         {
            Value = pValue,
            FieldName = pFieldName,
            ErrorMsg = pErrorMsg
         };
         return validator;
      }
      public static IValidator Empty()
      {
         return Empty(null, string.Empty, string.Empty);
      }
      public static IValidator Empty(string pErrorMsg)
      {
         return Empty(null, string.Empty, pErrorMsg);
      }
      static IValidator NotEmpty(object pValue, string pFieldName, string pErrorMsg)
      {
         IValidator validator = new NotEmpty()
         {
            Value = pValue,
            FieldName = pFieldName,
            ErrorMsg = pErrorMsg
         };
         return validator;
      }
      public static IValidator NotEmpty()
      {
         return NotEmpty(null, string.Empty, string.Empty);
      }
      public static IValidator NotEmpty(string pErrorMsg)
      {
         return NotEmpty(null, string.Empty, pErrorMsg);
      }

      static IValidator Ge(object pValue, object pMin, string pFieldName, string pErrorMsg)
      {
         IValidator validator = new Ge()
         {
            Value = pValue,
            Min = pMin,
            ErrorMsg = pErrorMsg,
            FieldName = pFieldName
         };
         return validator;
      }
      public static IValidator Ge(object pMin, string pErrorMsg)
      {
         return Ge(null, pMin, string.Empty, pErrorMsg);
      }
      public static IValidator Ge(object pMin)
      {
         return Ge(null, pMin, string.Empty, string.Empty);
      }
      static IValidator Gt(object pValue, object pMin, string pFieldName, string pErrorMsg)
      {
         IValidator validator = new Gt()
         {
            Value = pValue,
            Min = pMin,
            ErrorMsg = pErrorMsg,
            FieldName = pFieldName
         };
         return validator;
      }
      public static IValidator Gt(object pMin, string pErrorMsg)
      {
         return Gt(null, pMin, string.Empty, pErrorMsg);
      }
      public static IValidator Gt(object pMin)
      {
         return Gt(null, pMin, string.Empty, string.Empty);
      }
      static IValidator Le(object pValue, object pMax, string pFieldName, string pErrorMsg)
      {
         IValidator validator = new Le()
         {
            Value = pValue,
            Max = pMax,
            ErrorMsg = pErrorMsg,
            FieldName = pFieldName
         };
         return validator;
      }
      public static IValidator Le(object pMax, string pErrorMsg)
      {
         return Le(null, pMax, string.Empty, pErrorMsg);
      }
      public static IValidator Le(object pMax)
      {
         return Le(null, pMax, string.Empty, string.Empty);
      }
        static IValidator Lt(object pValue, object pMax, string pFieldName, string pErrorMsg)
      {
         IValidator validator = new Lt()
         {
            Value = pValue,
            Max = pMax,
            FieldName = pFieldName
         };
         return validator;
      }
      public static IValidator Lt(object pMax, string pErrorMsg)
      {
         return Lt(null, pMax, string.Empty, pErrorMsg);
      }
      public static IValidator Lt(object pMax)
      {
         return Lt(null, pMax, string.Empty, string.Empty);
      }

      public static IValidator Equal(object pValue, object pEqualsToObject, string pFieldName, string pFieldName2)
      {
         IValidator validator = new Equal()
         {
            Value = pValue,
            EqualsToObject = pEqualsToObject,
            FieldName2 = pFieldName2,
            FieldName = pFieldName
         };
         return validator;
      }
   }
}
