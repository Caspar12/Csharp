using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh.Framework.Tools.SerializeTool.Imp;
using Zh.Framework.Tools.SerializeTool;
using Zh.Framework.Entities;

namespace Zh.Framework.Test.Tools.SerializeTool
{
    /// <summary>
    /// UnitTest1 的摘要说明
    /// </summary>
    [TestClass]
    public class XmlSerializeToolImpTest
    {
        public XmlSerializeToolImpTest()
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

        public void DeserializeFromFileTest()
        {
            ISerializeTool tISerializeTool = new XmlSerializeToolImp();

            var r = tISerializeTool.DeserializeFromFile<List<Cache.Entities.CacheDto>>(@"d:\cache.cache");
        }
        public void SerializeToFileTest()
        {
            ISerializeTool tISerializeTool = new XmlSerializeToolImp();
            var r = new List<Cache.Entities.CacheDto>();
            tISerializeTool.SerializeToFile(r, @"d:\cache.cache");
        }
        public void SerializeAllTest()
        {
            ISerializeTool tISerializeTool = new XmlSerializeToolImp();
            var r = new List<Cache.Entities.CacheDto>();
            r.Add(new Cache.Entities.CacheDto()
            {
                Key = "a;sldfkja;sdfj;asf",
                Value = ";alksdjf;alskdjf;alskdjf;aslkdjf;alksdjf;askldj ;klvja;ksljfdlkasdf"
            });
            var content = tISerializeTool.SerializeToString(r);
            var rto = tISerializeTool.DeserializeFromString<List<Cache.Entities.CacheDto>>(content);

            tISerializeTool.SerializeToFile(r, @"D:\cache.cache");
            var r2 = tISerializeTool.DeserializeFromFile<List<Cache.Entities.CacheDto>>(@"D:\cache.cache");
        }
    }
}
