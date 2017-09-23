using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Zh.Comp.DataValidator.Model
{
    public class ValidResult
    {
        public bool Success
        {
            get
            {
                return this.ValidationResults.Count == 0;
            }
        }

        public List<ValidationResult> ValidationResults { get; set; } = new List<ValidationResult>();
    }
}
