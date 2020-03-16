
using Autofac;
using Vueling.Domain.Entites;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Implementations;

namespace Vueling.Application.Logic.AutofacModules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<StudentRepository>()
                .As<IRepository<Student>>()
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
