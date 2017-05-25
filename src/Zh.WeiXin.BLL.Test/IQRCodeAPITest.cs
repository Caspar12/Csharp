using Zh.WeiXin.BLL.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zh.WeiXin.BLL.API.Entities;
using System.Drawing;
using Zh.Framework.Entities;
using Zh.Framework.Tools;
using Zh.Framework.Cache.Entities;
using System.Collections.Generic;

namespace Zh.WeiXin.BLL.Test
{


    /// <summary>
    ///这是 IQRCodeAPITest 的测试类，旨在
    ///包含所有 IQRCodeAPITest 单元测试
    ///</summary>
    [TestClass()]
    public class IQRCodeAPITest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual IQRCodeAPI CreateIQRCodeAPI()
        {
            // TODO: 实例化相应的具体类。
            IQRCodeAPI target = ToolFactory.Ioc.Get<IQRCodeAPI>();
            return target;
        }

        /// <summary>
        ///CreateByQRCodeImage 的测试
        ///</summary>
        public void CreateByQRCodeImageTest()
        {
            IBasicAPI iBasicAPI = ToolFactory.Ioc.Get<IBasicAPI>();

            IQRCodeAPI target = CreateIQRCodeAPI(); // TODO: 初始化为适当的值
            var accessToken = iBasicAPI.GetAccessToken("wx5a15c9e5c52de05b", "740bceb8cc078267c67795bd91d8e203");
            var qrCodePostDataDto = target.CreateTemporaryQRCodePostDataDto(accessToken.access_token, 60, 1);
            GetQRCodeTicketResultDto getQRCodeTicketResultDto = target.GetQRCodeTicket(accessToken.access_token, qrCodePostDataDto);
            int imageWidth = 400; // TODO: 初始化为适当的值
            int imageHeight = 400; // TODO: 初始化为适当的值
            GenericExecResult<Image> expected = null; // TODO: 初始化为适当的值
            GenericExecResult<Image> actual;
            actual = new GenericExecResult<Image>() { Data = target.CreateQRCodeImageByQRCodePostDataDto(getQRCodeTicketResultDto, imageWidth, imageHeight) };
            var ixml = ToolFactory.CreateIXmlSerializeTool();
            ixml.SerializeToFile(getQRCodeTicketResultDto, "D:\\d.xml");
            actual.Data.Save("D:\\t.png");
            // Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
        public void XmlSerializeTest()
        {

            var ixml = ToolFactory.CreateIXmlSerializeTool();
            var r = new GetAccessTokenResult()
            {
                access_token = "j;alskdjf;asldkfj",
                expires_in = 7200
            };
            CacheDto s = new CacheDto()
            {
                Value = r,
                Key = "lkjl",
                Expire = DateTime.Now.AddDays(2)
            };
            List<CacheDto> l = new List<CacheDto>() { 
            s
            };
            ixml.SerializeToFile(l, "D:\\d.xml");
            ixml.DeserializeFromFile<List<CacheDto>>("D:\\d.xml");
        }
        public void UrlEncodeTest()
        {
            IQRCodeAPI target = CreateIQRCodeAPI();
            var r = target.GetWeiXinQRCodeImageUrl(new GetQRCodeTicketResultDto()
             {
                 ticket = "gQGV8DoAAAAAAAAAASxodHRwOi8vd2VpeGluLnFxLmNvbS9xL2FIVWw5OGZscWpIVFlEMU5UbHNTAAIEswTpVgMEPAAAAA=="
             });
            var k = 0;
        }
    }
}
