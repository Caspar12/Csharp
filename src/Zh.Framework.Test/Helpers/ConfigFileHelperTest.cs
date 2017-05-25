using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zh.Framework.Helpers;
using Zh.Framework.Test.Helpers.Entities;

namespace Zh.Framework.Test.Helpers
{
    [TestClass]
    public class ConfigFileHelperTest
    {
        public void LoadTest()
        {
            var configHelper = new ConfigFileHelper<ConfigTestDto>("");
        }
        [TestMethod]
        public void SaveTest()
        {
            var configHelper = new ConfigFileHelper<List<ConfigTestDto>>("configTest");

            configHelper.Save(new List<ConfigTestDto>() {
                new ConfigTestDto()
            {
                Name = "test",
                OutputCacheLocation = System.Web.UI.OutputCacheLocation.Any,
                Value = 1
            }
            });
        }
    }
}
