using Autofac;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Domain.Entites;
using Vueling.Infrastructure.Repository.Implementations;
using Vueling.Test.Framework;

namespace Vueling.Infrastructure.Repository.Integration.Tests.AutofacModules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<StudentRepository>()
                .As<IRepository<Student>>();

            builder.RegisterModule<LoggingModule>();

            base.Load(builder);
        }
    }
}
