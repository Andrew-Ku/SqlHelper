using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Core.Consts;
using XrmTaskHelper.Domain.Interfaces;

namespace XrmTaskHelper.Services.Interfaces
{
    public interface IRepositoryFactory
    {
        IRepository<T> Create<T>() where T : class;

        IRepository<T> Create<T>(DbContextKeys key) where T : class;
    }
}
