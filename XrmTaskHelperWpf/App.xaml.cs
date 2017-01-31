using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Microsoft.Practices.ServiceLocation;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Domain.Interfaces;
using XrmTaskHelper.Infrastructure.Data.Contexts;
using XrmTaskHelper.Infrastructure.Data.Repositories;
using XrmTaskHelper.Services.DomainServices;
using XrmTaskHelperWpf.Services.Impl;
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
            AutofacConfig.ConfigureAndRun();
            AutoMapperConfig.ConfigureAndRun();


//            var ds = ServiceLocator.Current.GetInstance(typeof(XrmTaskDomainService)) as XrmTaskDomainService;
//
//            var d = new XrmTask()
//            {
//                Name = "xrm",
//                CompleteDate = DateTime.Today,
//                CreateDate = DateTime.Today,
//                
//                
//            };
//           
//          
//            d.Items.Add(new XrmTaskItem()
//            {
//                CreateDate = DateTime.Today,
//                Name = "dss"
//            });
//            ds.Add(new XrmTask()
//            {
//                Description = "Тестовая запрись",
//                CreateDate = DateTime.Now,
//                Name = "XRM-1232",
//                Note = "Выполнить пункт 2",
//                Items = new List<XrmTaskItem>()
//                {
//                    new XrmTaskItem()
//                    {
//                        Description = "Desd",
//                        Name = "Примечание",
//                        CreateDate = DateTime.Today,
//                        Note = "",
//                    },
//                    new XrmTaskItem()
//                    {
//                         Description = "sdsd",
//                        Name = "Примеsdsчание",
//                        CreateDate = DateTime.Today,
//                        Note = "1",
//                    },
//                      new XrmTaskItem()
//                    {
//                         Description = "cx",
//                        Name = "Приме12",
//                        CreateDate = DateTime.Today,
//                        Note = "2",
//                    }
//                }
//            });
//
//            ds.Add(d);
//            ds.Save();
//            
            
            var model = ServiceLocator.Current.GetInstance(typeof(MainWindowVm));

            var view = new MainWindow() { DataContext = model };
            view.Show();
        }
    }
}
