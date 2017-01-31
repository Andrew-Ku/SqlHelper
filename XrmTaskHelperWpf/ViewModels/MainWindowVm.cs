using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelperWpf.Services.Interfaces;

namespace XrmTaskHelperWpf.ViewModels
{
    [ImplementPropertyChanged]
//    public class MainWindowVm : BaseViewModel
    public class MainWindowVm
    {
        private readonly IXrmTaskService _xrmTaskService;

        public ObservableCollection<XrmTaskVm> XrmTaskList { get; set; }

        public string TestStr { get; set; }


        public MainWindowVm(IXrmTaskService xrmTaskService)
        {
            _xrmTaskService = xrmTaskService;
          
            XrmTaskList = new ObservableCollection<XrmTaskVm>(_xrmTaskService.GetTasksVm(p => p.Items));

         
        }
    }
}
