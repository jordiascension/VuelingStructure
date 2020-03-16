1.Vueling Business Facade
startup page: api/student
AssemblyInfo.cs
lognet.config
Global.asax
AutofacConfig.cs
FacadeModule.cs
LoggingModule.cs
StudentController.cs
NotImplementedExceptionFilterAttribute.cs

2.Vueling Application Logic
IService
StudentService
  ArgumentNullException
ApplicationModule

3.Vueling Infrastructure Repository
IRepository
StudentRepository
  ArgumentNullException

4.Vueling Test Framework
IoCSupportedTest
LoggingModule

5.Vueling.Infrastructure.Repository.Integration.Test
RepositoryModule
StudentRepositoryTests

6.Vueling.Domain.Entities
IDomainObject
Student