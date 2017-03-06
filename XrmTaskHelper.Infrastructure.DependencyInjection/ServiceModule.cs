using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Domain.Interfaces;
using XrmTaskHelper.Services;
using XrmTaskHelper.Services.DomainServices;
using XrmTaskHelper.Services.Interfaces;

namespace XrmTaskHelper.Infrastructure.DependencyInjection
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BaseDomainService<>)).As(typeof(BaseDomainService<>));
            builder.Register(c => new XrmTaskDomainService(c.Resolve<IRepository<XrmTask>>())).As(typeof(XrmTaskDomainService));
            builder.Register(c => new XrmTaskItemDomainService(c.Resolve<IRepository<XrmTaskItem>>())).As(typeof(XrmTaskItemDomainService));
            builder.Register(c => new DefaultDialogService()).As(typeof(IDialogService));
        }
    }
}
