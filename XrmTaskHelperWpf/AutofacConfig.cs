using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;
using XrmTaskHelper.Infrastructure.DependencyInjection;
using XrmTaskHelperWpf.Services.Impl;

namespace XrmTaskHelperWpf
{
    public static class AutofacConfig
    {
        public static void ConfigureAndRun()
        {

            var builder = new ContainerBuilder();

            builder.RegisterModule(new DataAccessModule());
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new UiServiceModule());

            var container = builder.Build();

            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);
        }
    }
}
