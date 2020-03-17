using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vueling.Domain.Entites;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Integration.Tests.AutofacModules;
using Vueling.Test.Framework;

namespace Vueling.Infrastructure.Repository.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentRepositoryTests: 
        IoCSupportedTest<RepositoryModule>
    {
        private IRepository<Student> repository = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            log4net.Config.XmlConfigurator.Configure();
        }
         
        [TestInitialize]
        public void SetUp()
        {
            repository = Resolve<IRepository<Student>>();
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
            List<Student> studentList = repository.GetAll();

            Assert.IsTrue(studentList.Count==2,
                "studentList is 0 or null");       
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}