using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Test.Framework;
using Vueling.Application.Logic.Integration.Tests.AutofacModules;
using log4net.Config;

namespace Vueling.Application.Logic.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentServiceTests:
        IoCSupportedTest<ApplicationModule>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            XmlConfigurator.Configure();
        }


        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}