using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using XrmTaskHelper.Core.Consts;
using XrmTaskHelper.Domain.Interfaces;
using XrmTaskHelper.Services.Interfaces;

namespace XrmTaskHelper.Infrastructure.Data.Services
{
    public class RepositoryFactory : IRepositoryFactory
    {
         private readonly IComponentContext context;

         public RepositoryFactory(IComponentContext context)
        {
            this.context = context;
        }

        public IRepository<T> Create<T>() where T : class
        {
            return context.Resolve<IRepository<T>>();
        }

        public IRepository<T> Create<T>(T type) where T : class
        {
            return context.Resolve<IRepository<T>>();
        }

        public IRepository<T> Create<T>(DbContextKeys key) where T : class
        {
            return context.ResolveKeyed<IRepository<T>>(key);
        }
    }
}
