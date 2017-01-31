using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelper.Infrastructure.Data.Repositories
{
    public class Repository<T>: BaseRepository<T> where T:class 
    {
        public Repository(DbContext context) : base(context)
        {
        }
    }
}
