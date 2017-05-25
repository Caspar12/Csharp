using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Zh.Framework.Test.Helpers.Entities
{
    public class ConfigTestDto
    {
        public string Name{get;set;}
        public int Value { get; set; }
        public OutputCacheLocation OutputCacheLocation { get; set; }

    }
}
