using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using XrmTaskHelper.Infrastructure.Data.Contexts;

namespace XrmTaskHelper.Infrastructure.DependencyInjection
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new TaskDbContext()).As<DbContext>();
        }
    }
}
