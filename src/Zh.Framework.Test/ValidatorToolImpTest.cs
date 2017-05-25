using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh.Framework.Tools.ValidatorTool.Validator;
using System.Collections.Specialized;
using Zh.Framework.Tools.ValidatorTool.Validator.NVCollectionValidator;
using System.Diagnostics;
using Zh.Framework.Tools;
using Zh.Framework.Helpers;

namespace Zh.Framework.Test
{
    [TestClass]
    public class ValidatorToolImpTest
    {
        public void TestValidators()
        {

        }
        public void TestNVCollectionValidator()
        {
            var tNameValueCollection = new NameValueCollection();
            tNameValueCollection.Add("Name", "Name");
            tNameValueCollection.Add("BeginTime", DateTime.Now.ToString("yyyy-MM-dd"));
            tNameValueCollection.Add("EndTime", null);
            tNameValueCollection.Add("Count", "0");

            var tNVValidator = ToolFactory.CreateIValidatorTool().CreateNVValidator(tNameValueCollection);
            tNVValidator.SetField("Name", typeof(string), "名称")
                        .NotEmpty()
                        .Ge(6)
                        .Le(5);

            var r = tNVValidator.IsValid();

            Debug.WriteLine(r.Message);
        }

        [TestMethod]
        public void TestUrl()
        {
            var r = UrlHelper.Concat("http://localhost/", "/upload/user/42/123.jpg");
        }

        [TestMethod]
        public void TestEncrypt()
        {
            var input = "0_2016-08-09_11:30:00_234234";
            var key = "jsuy&12#";
            var iv = "()87^%#2";
            var encryptInput = EncryptHelper.DESEncrypt(input, key, iv);
            var decryptInput = EncryptHelper.DESDecrypt(encryptInput, key, iv);
            Assert.AreEqual(input, decryptInput);
        }

        [TestMethod]
        public void TestStringTimeSpan()
        {
            var kk = "kkkk";
            var tt = "ttt";
            //var r = "aaa\{kk}_bbb,tttkkk\{tt}";
            var t = DateTime.Parse("2016-07-29 11:18:45");
            var k = DateTimeHelper.DateTimeToUnix16(t);
        }
    }
}
