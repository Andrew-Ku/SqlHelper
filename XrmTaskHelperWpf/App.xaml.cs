using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelperWpf.ViewModels;
using XrmTaskHelperWpf.Views;

namespace XrmTaskHelperWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var tasks = new List<XrmTask>()
    {
        new XrmTask()
        {
            Id = 1,
            Name = "XRM-1555"
        },
         new XrmTask()
        {
            Id = 2,
            Name = "XRM-1423"
        },
         new XrmTask()
        {
            Id = 3,
            Name = "XRM-1236"
        },
    };

            var view = new MainWindow(); // создали View
            MainWindowVm viewModel = new MainWindowVm(tasks); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }


    }
}
