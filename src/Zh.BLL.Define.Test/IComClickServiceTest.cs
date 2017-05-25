using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh.BLL.Define.ServiceContexts;
using Zh.DAL.Base.Define.Query;
using Zh.DAL.Define.Contracts.Imp;
using Zh.Framework.Tools;
using Zh.DAL.Define.Contracts;

namespace Zh.BLL.Define.Test
{
    /// <summary>
    /// IComClickServiceTest 的摘要说明
    /// </summary>
    [TestClass]
    public class IComClickServiceTest
    {
        public IComClickServiceTest()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
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
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        ServiceContext ServiceContext = new Zh.BLL.Define.ServiceContexts.ServiceContext();
        [TestMethod]
        public void TestTransInsertAndQuery()
        {
            for (var i = 0; i < 200; i++)
            {
                var rnd = new Random();
                ServiceContext.IComClickService.Insert(new Entities.ComClickDto()
                {
                    ID = Guid.NewGuid(),
                    Category = "t",
                    ClickCount = rnd.Next(1, 200)
                });
            }
            var list = ServiceContext.IComClickService.Top(10, 50, OrderByHelper.Create().Desc("ClickCount"));
            var kk = 0;
        }

        [TestMethod]
        public void TestTr()
        {
            var list = ServiceContext.IComClickService.FindAll();
            var idList = list.Select(p => p.ID).ToList();
            foreach (var id in idList)
            {
                ServiceContext.IComClickService.Delete(id);
            }
        }
    }
}
