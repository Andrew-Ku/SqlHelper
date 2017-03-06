using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using XrmTaskHelper.Core.Consts;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Domain.Interfaces;
using XrmTaskHelper.Infrastructure.Data.Contexts;
using XrmTaskHelper.Infrastructure.Data.Repositories;
using XrmTaskHelper.Infrastructure.Data.Services;
using XrmTaskHelper.Services.Interfaces;

namespace XrmTaskHelper.Infrastructure.DependencyInjection
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new RepositoryFactory(c.Resolve<IComponentContext>())).As<IRepositoryFactory>();
            builder.Register(c => new Repository<XrmTask>(c.Resolve<DbContext>())).As<IRepository<XrmTask>>();
            builder.Register(c => new Repository<XrmTaskItem>(c.Resolve<DbContext>())).As<IRepository<XrmTaskItem>>();
        }
    }
}
