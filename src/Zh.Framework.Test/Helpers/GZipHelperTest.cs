
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Zh.Framework.Helpers;
using Zh.Framework.Tools;

namespace Zh.Framework.Test.Helpers
{
    [TestClass]
    public class GZipHelperTest
    {
        [TestMethod()]
        public void UnGZip()
        {


            var filePath = @"d:\2.gz";

            var jsonHelper = ToolFactory.CreateIJsonSerializeTool();
            using (var sr = GZipHelper.UnGZipToStreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    var l = sr.ReadLine();
                    var json = l + "]}";
             

                }
            }

            var i = 0;
        }

    }
}
