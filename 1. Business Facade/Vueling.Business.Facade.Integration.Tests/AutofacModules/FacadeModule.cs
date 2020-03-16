
using Autofac;
using System.Reflection;
using Vueling.Application.Logic.Contracts;
using Vueling.Application.Logic.Implementations;
using Vueling.Domain.Entites;

namespace Vueling.Business.Facade.Integration.Tests.AutofacModules
{
    public class FacadeModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterApiControllers(
              //  Assembly.GetExecutingAssembly());

            builder
                .RegisterType<StudentService>()
                .As<IService<Student>>()
                .InstancePerRequest();

            //builder.RegisterModule(new LoggingModule());

            base.Load(builder);
        }
    }
}
