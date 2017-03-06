using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Domain.Interfaces;
using XrmTaskHelper.Services.DomainServices;
using XrmTaskHelper.Services.Interfaces;
using XrmTaskHelperWpf.Services.Interfaces;
using XrmTaskHelperWpf.ViewModels;

namespace XrmTaskHelperWpf.Services.Impl
{
    public class UiServiceModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new FileService()).As<IFileService>();
            builder.Register(c => new XrmTaskService(c.Resolve<XrmTaskDomainService>(), c.Resolve<IFileService>(), c.Resolve<XrmTaskItemDomainService>())).As<IXrmTaskService>();
            builder.Register(c => new MainWindowVm(c.Resolve<IXrmTaskService>(),c.Resolve<IDialogService>())).AsSelf();
        }
    }
}
