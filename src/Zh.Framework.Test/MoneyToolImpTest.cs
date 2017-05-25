using Zh.Framework.Tools.MoneyTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Zh.Framework.Test
{


    /// <summary>
    ///This is a test class for MoneyToolImpTest and is intended
    ///to contain all MoneyToolImpTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MoneyToolImpTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Format
        ///</summary>
        public void FormatTest()
        {
            MoneyToolImp target = new MoneyToolImp(); // TODO: Initialize to an appropriate value


            string actual;
            actual = target.Format(Convert.ToDecimal("123456"), 2, FractionShowType.Always);
            Console.WriteLine(actual);

            actual = target.Format(Convert.ToDecimal("123456.12313"), 2, FractionShowType.Auto);
            Debug.WriteLine(actual);

            actual = target.Format(Convert.ToDecimal("123456.00"), 2, FractionShowType.Auto);
            Debug.WriteLine(actual);
        }

       [TestMethod]
        public void Test()
        {
            Framework.Helpers.FileHelper.IsImageFile("asdfsd.png");
        }
    }
}
