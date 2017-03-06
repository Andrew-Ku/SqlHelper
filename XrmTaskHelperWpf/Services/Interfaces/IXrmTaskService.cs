using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelperWpf.ViewModels;

namespace XrmTaskHelperWpf.Services.Interfaces
{
    public interface IXrmTaskService
    {
        int AddXrmTask(XrmTaskVm vm);

        void UpdateDataBase(bool clearAll = false);

        void DeleteFromDatabase();

        void EditXrmTask(XrmTaskVm vm);
        List<XrmTaskVm> GetTasksVm(params Expression<Func<XrmTask, object>>[] include);
    }
}
