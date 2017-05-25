using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh.Framework.Test.Helpers.Entities;
using Zh.Framework.Helpers;
using System.Collections;

namespace Zh.Framework.Test.Helpers
{
    /// <summary>
    /// ReflectorHelperTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ReflectorHelperTest
    {
        public ReflectorHelperTest()
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

        public void TestMethod1()
        {
            var parent = new Parent()
            {
                Name = "Parent"
            };

            var getPropertyResult = ReflectorHelper.GetProperty(parent, "name");
            Assert.AreEqual("Parent", getPropertyResult);

            ReflectorHelper.SetProperty(parent, "name", "name1");
            var getPropertyResult1 = ReflectorHelper.GetProperty(parent, "name");
            Assert.AreEqual("name1", getPropertyResult1);

            ReflectorHelper.SetProperty(parent, "child.name", "childname");
            var getPropertyResultChildName = ReflectorHelper.GetProperty(parent, "child.name");
            Assert.AreEqual("childname", getPropertyResultChildName);
        }

        [TestMethod]
        public void IsBaseValueTypeTest()
        {
            var b = true;
            b = ReflectorHelper.IsBaseValueType((typeof(int)));
            b = ReflectorHelper.IsBaseValueType((typeof(Int32)));
            b = ReflectorHelper.IsBaseValueType((typeof(string)));
            b = ReflectorHelper.IsBaseValueType((typeof(Guid)));
            b = ReflectorHelper.IsBaseValueType((typeof(DateTime)));
            b = ReflectorHelper.IsBaseValueType((typeof(decimal)));
            b = ReflectorHelper.IsBaseValueType((typeof(Decimal)));
            b = ReflectorHelper.IsBaseValueType((typeof(IList<>)));
            b = ReflectorHelper.IsBaseValueType((typeof(IList)));
            b = ReflectorHelper.IsBaseValueType((typeof(List<>)));
            b = ReflectorHelper.IsBaseValueType((typeof(Child)));
            b = ReflectorHelper.IsBaseValueType((typeof(ICollection<>)));
            b = ReflectorHelper.IsBaseValueType((typeof(ICollection)));
            b = ReflectorHelper.IsBaseValueType((typeof(Parent)));
            b = ReflectorHelper.IsBaseValueType((typeof(Type)));
            b = ReflectorHelper.IsBaseValueType((typeof(NotImplementedException)));



        }
    }
}
