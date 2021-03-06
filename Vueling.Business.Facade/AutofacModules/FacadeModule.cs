﻿

using Autofac;
using System.Reflection;
using Autofac.Integration.WebApi;
using Vueling.Application.Logic.Contracts;
using Vueling.Application.Logic.Implementations;
using Vueling.Domain.Entites;
using Vueling.Application.Logic.AutofacModules;

namespace Vueling.Business.Facade.AutofacModules
{
    public class FacadeModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(
                Assembly.GetExecutingAssembly());

            builder
                .RegisterType<StudentService>()
                .As<IService<Student>>()
                .InstancePerRequest();

            builder.RegisterModule(new LoggingModule());
            builder.RegisterModule(new ApplicationModule());

            base.Load(builder);
        }
    }
}