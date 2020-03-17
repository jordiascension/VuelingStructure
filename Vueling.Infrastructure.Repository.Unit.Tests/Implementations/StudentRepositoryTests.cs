using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Autofac.Extras.Moq;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Domain.Entites;

namespace Vueling.Infrastructure.Repository.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentRepositoryTests
    {
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
            using(var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock 
                List<Student> studentExpectedList = new List<Student>();
                Student student1 = new Student
                {
                    Name = "Pepe"
                };
                studentExpectedList.Add(student1);

                Student student2 = new Student
                {
                    Name = "Montse"
                };
                studentExpectedList.Add(student2);

                mock.Mock<IRepository<Student>>().
                    Setup(repository => repository.GetAll()).
                    Returns(studentExpectedList);

                var mockedStudentRepository = 
                    mock.Create<IRepository<Student>>();

                //Act
                var studentList = mockedStudentRepository.GetAll();
                
                // Assert
                //verify that GetAll is called one time
                mock.Mock<IRepository<Student>>().
                    Verify(repository => repository.GetAll());

                Assert.IsTrue(studentList.Count == studentExpectedList.Count);
            }
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}