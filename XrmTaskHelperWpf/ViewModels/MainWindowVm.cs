using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelperWpf.ViewModels
{
    public class MainWindowVm : BaseViewModel
    {
        ObservableCollection<XrmTaskVm> XrmTaskList { get; set; }

        public MainWindowVm(List<XrmTask> xrmTasks)
        {
            XrmTaskList = new ObservableCollection<XrmTaskVm>(xrmTasks.Select(b => new XrmTaskVm(b)));
        }
    }
}
