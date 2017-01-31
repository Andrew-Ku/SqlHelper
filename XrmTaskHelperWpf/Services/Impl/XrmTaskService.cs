using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Services.DomainServices;
using XrmTaskHelperWpf.Services.Interfaces;
using XrmTaskHelperWpf.ViewModels;

namespace XrmTaskHelperWpf.Services.Impl
{
    public class XrmTaskService : IXrmTaskService
    {
        private readonly XrmTaskDomainService _xrmTaskDs;

        public XrmTaskService(XrmTaskDomainService xrmTaskDs)
        {
            _xrmTaskDs = xrmTaskDs;
        }

        public int AddXrmTask(XrmTaskVm vm)
        {
            var model = Mapper.Map<XrmTaskVm, XrmTask>(vm);

            _xrmTaskDs.Add(model);
            var newId = _xrmTaskDs.Save();

            return newId;
        }

        public void EditXrmTask(XrmTaskVm vm)
        {
            var xrmTasks = _xrmTaskDs.GetAll().Single(m => m.Id == vm.Id);
            Mapper.Map(vm, xrmTasks);

            _xrmTaskDs.Save();
        }


        public List<XrmTaskVm> GetTasksVm(params Expression<Func<XrmTask, object>>[] include)
        {
            var xrmTasks = _xrmTaskDs.AllIncluding(include).ToList().Select(Mapper.Map<XrmTask, XrmTaskVm>).ToList();

            return xrmTasks;
        }
    }
}
