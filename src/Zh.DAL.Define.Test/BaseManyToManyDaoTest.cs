using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh.Framework.Tools;
using Zh.DAL.Base.NH;
using Zh.DAL.Define.Entities;
using NHibernate.Criterion;

namespace Zh.DAL.Define.Test
{
    /// <summary>
    /// BaseManyToManyDaoTest 的摘要说明
    /// </summary>
    [TestClass]
    public class BaseManyToManyDaoTest
    {
        public BaseManyToManyDaoTest()
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

        public void Find()
        {
            var nHBaseDaoTemplate = ToolFactory.Ioc.Get<NHBaseDaoTemplate>("Zh.DAL.Define.BaseDaoTemplate");
            var iCriteria = nHBaseDaoTemplate.Session.CreateCriteria<Com_AbstractLeftTableToRightTableRef>();
            var rightCriteria = iCriteria.CreateCriteria("Right", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
            rightCriteria.Add(Restrictions.Eq("Id", new Guid("C8926DF0-2425-46D2-B285-0CE222E7D738")));
            var list = iCriteria.List<Com_AbstractLeftTableToRightTableRef>();
            var rightList = rightCriteria.List<Com_AbstractLeftTableToRightTableRef>();
        }
        public void InitAbstractManyToManyData()
        {
           


        }
    }
}
