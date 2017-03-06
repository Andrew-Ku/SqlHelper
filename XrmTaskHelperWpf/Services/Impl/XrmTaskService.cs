using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using XrmTaskHelper.Core.Consts;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Services.DomainServices;
using XrmTaskHelperWpf.Services.Interfaces;
using XrmTaskHelperWpf.ViewModels;

namespace XrmTaskHelperWpf.Services.Impl
{
    public class XrmTaskService : IXrmTaskService
    {
        private readonly XrmTaskDomainService _xrmTaskDs;
        private readonly XrmTaskItemDomainService _xrmTaskItemDs;
        private readonly IFileService _fileService;

        public XrmTaskService(XrmTaskDomainService xrmTaskDs, IFileService fileService, XrmTaskItemDomainService xrmTaskItemDs)
        {
            _xrmTaskDs = xrmTaskDs;
            _fileService = fileService;
            _xrmTaskItemDs = xrmTaskItemDs;
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
            var vm = new List<XrmTaskVm>();
            var xrmTasks = _xrmTaskDs.AllIncluding(include).ToList();

            foreach (var xrmTask in xrmTasks)
            {
                var xrmTaskVm = Mapper.Map<XrmTask, XrmTaskVm>(xrmTask);
                var isExistDirectory = _fileService.IsExistDirectory(Path.Combine(Paths.TasksDirectory, xrmTask.Name));
                xrmTaskVm.IconSource = IconPath.Task;

                if (!isExistDirectory)
                {
                    xrmTaskVm.IsNotFound = true;
                    vm.Add(xrmTaskVm);
                    continue;
                }

                foreach (var item in xrmTask.Items)
                {
                    var xrmTaskItemVm = Mapper.Map<XrmTaskItem, XrmTaskItemVm>(item);
                    var isExistFile = _fileService.IsExistFile(Path.Combine(Paths.TasksDirectory, xrmTask.Name, item.Name));
                    xrmTaskItemVm.IconSource = IconPath.GetIconPathByExtension(Path.GetExtension(item.Name));

                    if (!isExistFile)
                    {
                        xrmTaskItemVm.IsNotFound = true;

                    }

                    xrmTaskVm.Items.Add(xrmTaskItemVm);
                }

                vm.Add(xrmTaskVm);
            }

            return vm;
        }

        public void UpdateDataBase(bool clearAll = false)
        {
            var directories = _fileService.GetDirectories(Paths.TasksDirectory);

            foreach (var directory in directories)
            {
                var xrmTask = new XrmTask
                {
                    Name = directory.Name,
                    CreateDate = directory.CreationTime,
                    Path = directory.FullName
                };

                var files = _fileService.GetFiles(directory.FullName);

                foreach (var file in files)
                {
                    var xrmTaskItem = new XrmTaskItem()
                    {
                        Name = file.Name,
                        CreateDate = file.CreationTime,
                        Path = file.FullName
                    };

                    xrmTask.Items.Add(xrmTaskItem);
                }

                _xrmTaskDs.Add(xrmTask);
            }

            _xrmTaskDs.Save();
        }


        public void DeleteFromDatabase()
        {
            var xrmTasks = _xrmTaskDs.GetAll().ToList();

            foreach (var xrmTask in xrmTasks)
            {
                _xrmTaskDs.Remove(xrmTask);
            }
            
            _xrmTaskDs.Save();
        }
    }
}
