using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Domain.Interfaces;

namespace XrmTaskHelper.Services.DomainServices
{
    public class XrmTaskDomainService : BaseDomainService<XrmTask>
    {
        public XrmTaskDomainService(IRepository<XrmTask> repository) : base(repository)
        {
        }
    }
}
