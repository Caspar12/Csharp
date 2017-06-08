using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zh.Web.Mvc.Framework.Test.Models
{
    public class ConstraintsValidationExceptionTest
    {
        [Required]
        public string Id { get; set; }
        [Display(Description = "Description", Name = "Name", ShortName = "ShortName")]
        [Required]
        [StringLength(maximumLength: 32, ErrorMessage = "StringLengthName", MinimumLength = 4)]
        public string Name { get; set; }
    }
}