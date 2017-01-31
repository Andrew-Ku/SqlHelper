using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Infrastructure.Data.Mapping;

namespace XrmTaskHelper.Infrastructure.Data.Contexts
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
            : base("TaskDb")
        {
            Database.SetInitializer<TaskDbContext>(new CreateDatabaseIfNotExists<TaskDbContext>());

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new XrmTaskMap());
            modelBuilder.Configurations.Add(new XrmTaskItemMap());
            modelBuilder.Configurations.Add(new TagMap());
        }
    }
}
