using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Zh.Comp.DataValidator.Model
{
    public class TestModel
    {

        public string value { get; set; }
        [Required]
        public string name { get; set; }
    }
}
