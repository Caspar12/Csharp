using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Zh.Comp.DataValidator.Model;

namespace Zh.Comp.DataValidator.Util
{
    public class DataValidatorUtils
    {
        public static List<ValidationResult> Valid(object data)
        {
            var tValidationContext = new ValidationContext(data, null, null);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(data, tValidationContext, results);
            return results;
        }

        public static ValidResult ValidEx(object data)
        {
            var validattionResults = Valid(data);
            return new ValidResult()
            {
                ValidationResults = validattionResults
            };
        }
    }
}
