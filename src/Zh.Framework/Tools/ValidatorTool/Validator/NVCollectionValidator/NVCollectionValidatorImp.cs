/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace Zh.Framework.Tools.ValidatorTool.Validator.NVCollectionValidator
{
   public class NVCollectionValidatorImp : IValidatorChain
   {
      public NVCollectionValidatorImp(NameValueCollection pNameValueCollection)
      {
         this.NameValueCollection = pNameValueCollection;
      }
      string Name;
      Type ValueType;
      string FieldName;
      NameValueCollection NameValueCollection;
      Dictionary<string, ValidatorSet> ValidatorDict = new Dictionary<string, ValidatorSet>();
      object ConvertToValue()
      {
         return ConvertToValue(this.Name);
      }
      object ConvertToValue(string pName)
      {
         string valueString = this.NameValueCollection[pName];

         return Convert.ChangeType(valueString, this.ValueType);
      }
      void AddValidator(IValidator pIValidator)
      {
         this.ValidatorDict[this.Name].IValidators.Add(pIValidator);
      }
      public IValidatorChain SetField(string pName, Type pValueType, string pFieldName)
      {
         this.Name = pName;
         this.ValueType = pValueType;
         if (!string.IsNullOrEmpty(pFieldName))
         {
            this.FieldName = pFieldName;
         }
         if (!this.ValidatorDict.ContainsKey(this.Name))
         {
            this.ValidatorDict.Add(pName, new ValidatorSet());
         }
         return this;
      }

      public IValidatorChain SetField(string pName, Type pValueType)
      {
         return SetField(pName, pValueType, string.Empty);
      }

      public IValidatorChain NotEmpty()
      {
         return NotEmpty(string.Empty);
      }

      public IValidatorChain NotEmpty(string pErrorMsg)
      {
         object value = ConvertToValue();
         Imp.NotEmpty validator = new Imp.NotEmpty()
         {
            FieldName = this.FieldName,
            Value = value,
            ErrorMsg = pErrorMsg
         };
         AddValidator(validator);
         return this;
      }

      public IValidatorChain Ge(object pMin)
      {
         return Ge(pMin, string.Empty);
      }

      public IValidatorChain Ge(object pMin, string pErrorMsg)
      {
         object value = ConvertToValue();
         Imp.Ge validator = new Imp.Ge()
         {
            ErrorMsg = pErrorMsg,
            Value = value,
            Min = pMin,
            FieldName = this.FieldName
         };
         AddValidator(validator);
         return this;
      }

      public IValidatorChain Gt(object pMin)
      {
         return Gt(pMin, string.Empty);
      }

      public IValidatorChain Gt(object pMin, string pErrorMsg)
      {
         object value = ConvertToValue();
         Imp.Gt validator = new Imp.Gt()
         {
            ErrorMsg = pErrorMsg,
            Value = value,
            Min = pMin,
            FieldName = this.FieldName
         };
         AddValidator(validator);
         return this;
      }

      public IValidatorChain Le(object pMax)
      {
         return Le(pMax, string.Empty);
      }

      public IValidatorChain Le(object pMax, string pErrorMsg)
      {
         object value = ConvertToValue();
         Imp.Le validator = new Imp.Le()
         {
            ErrorMsg = pErrorMsg,
            Value = value,
            Max = pMax,
            FieldName = this.FieldName
         };
         AddValidator(validator);
         return this;
      }

      public IValidatorChain Lt(object pMax)
      {
         return Lt(pMax, string.Empty);
      }

      public IValidatorChain Lt(object pMax, string pErrorMsg)
      {
         object value = ConvertToValue();
         Imp.Lt validator = new Imp.Lt()
         {
            ErrorMsg = pErrorMsg,
            Value = value,
            Max = pMax,
            FieldName = this.FieldName
         };
         AddValidator(validator);
         return this;
      }

      public IValidatorChain Equal(string pEqualsToName, string pEqualsToFieldName)
      {
         return Equal(pEqualsToName, pEqualsToFieldName);
      }
      public IValidatorChain Equal(string pEqualsToName, string pEqualsToFieldName, string pErrorMsg)
      {
         object value = ConvertToValue();
         object equalsToValue = ConvertToValue(pEqualsToName);
         Imp.Equal validator = new Imp.Equal()
         {
            ErrorMsg = pErrorMsg,
            Value = value,
            EqualsToObject = equalsToValue,
            FieldName2 = pEqualsToFieldName,
            FieldName = this.FieldName
         };
         AddValidator(validator);
         return this;
      }

      public Entities.ExecResult IsValid()
      {
         ValidatorSet tValidatorSet = new ValidatorSet();
         foreach (var item in this.ValidatorDict)
         {
            tValidatorSet.IValidators.AddRange(item.Value.IValidators);
         }
         return tValidatorSet.IsValid();
      }
   }
}
