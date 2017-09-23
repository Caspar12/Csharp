using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh.Comp.DataValidator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zh.Comp.DataValidator.Model;

namespace Zh.Comp.DataValidator.Util.Tests
{
    [TestClass()]
    public class DataValidatorUtilsTests
    {
        [TestMethod()]
        public void ValidTest()
        {
            var data = new TestModel()
            {
                name = "a"
            };
            var r = DataValidatorUtils.Valid(data);

            Console.WriteLine(r);
        }
    }
}