using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PropertyChanged;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Services.Interfaces;
using XrmTaskHelperWpf.Commands;
using XrmTaskHelperWpf.Services.Impl;
using XrmTaskHelperWpf.Services.Interfaces;

namespace XrmTaskHelperWpf.ViewModels
{
    [ImplementPropertyChanged]
    //    public class MainWindowVm : BaseViewModel
    public class MainWindowVm
    {
        private readonly IXrmTaskService _xrmTaskService;
        private readonly IDialogService _dialogService;

        public MainWindowVm(IXrmTaskService xrmTaskService, IDialogService dialogService)
        {
            _xrmTaskService = xrmTaskService;
            _dialogService = dialogService;

            XrmTaskCacheList = new List<XrmTaskVm>(_xrmTaskService.GetTasksVm(p => p.Items));
            XrmTaskList = new ObservableCollection<XrmTaskVm>(XrmTaskCacheList);

            Search = new SearchVm()
            {
                Name = "",
                Tag = ""
            };
            FontSizes = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17, 18 };

        }

        public ObservableCollection<XrmTaskVm> XrmTaskList { get; set; }
        public List<XrmTaskVm> XrmTaskCacheList { get; set; } //MyNote: останвился тут . Реализация поиска. Фильтр
        public XrmTaskVm SelectedXrmTask { get; set; }

        public SearchVm Search { get; set; }
        public List<int> FontSizes { get; set; }

        // команда обновления базы по существующей структуре каталога
        private RelayCommand _updateCommand;
        public RelayCommand UpdateCommand
        {
            get
            {
                return _updateCommand ??
                  (_updateCommand = new RelayCommand(obj =>
                  {

                      _xrmTaskService.UpdateDataBase();
                      XrmTaskList = new ObservableCollection<XrmTaskVm>(_xrmTaskService.GetTasksVm(p => p.Items));
                      _dialogService.ShowMessage("Обновлено");
                  }));
            }
        }

        // команда удаления из базы
        private RelayCommand _deleteCommand;

        public RelayCommand DeleteCommand //MyNote: отслеживать удаление каталогов
        {
            get
            {
                return _deleteCommand ??
                  (_deleteCommand = new RelayCommand(obj =>
                  {
                      _xrmTaskService.DeleteFromDatabase();
                      XrmTaskList = new ObservableCollection<XrmTaskVm>(_xrmTaskService.GetTasksVm(p => p.Items));
                      _dialogService.ShowMessage("Удалено!");
                  }));
            }
        }

        // команда поиска задачи
        private RelayCommand _searchTaskCommand;

        public RelayCommand SearchTaskCommand 
        {
            get
            {
                return _searchTaskCommand ??
                  (_searchTaskCommand = new RelayCommand(obj =>
                  {
                      var search = obj as SearchVm;
                      if (search != null && search.Name!=null)
                      {
                          var newXrmTasks = new List<XrmTaskVm>();

                          var searchName = search.Name.ToLower();
                          if (searchName == string.Empty)
                          {
                              newXrmTasks = XrmTaskCacheList;
                          }
                          else if (search.Name.Length > 1)
                          {
                              foreach (var task in XrmTaskCacheList)
                              {
                                  var newXrmTaskItems = new List<XrmTaskItemVm>();

                                  foreach (var taskItem in task.Items)
                                  {
                                      if (taskItem.Name.ToLower().Contains(searchName))
                                      {
                                          newXrmTaskItems.Add(taskItem);
                                      }
                                  }

                                  if (task.Name.ToLower().Contains(searchName) && !newXrmTaskItems.Any())
                                  {
                                      newXrmTasks.Add(task);

                                  }
                                  else if (newXrmTaskItems.Any())
                                  {
                                      task.IsExpanded = true;
                                      task.Items = newXrmTaskItems;
                                      newXrmTasks.Add(task);
                                  }
                              } 
                          }
                          else
                          {
                              newXrmTasks = XrmTaskList.ToList();
                              foreach (var xrmTask in newXrmTasks)
                              {
                                  xrmTask.IsExpanded = false;
                              }
                          }

                          XrmTaskList = new ObservableCollection<XrmTaskVm>(newXrmTasks);
                      }
                     
                  }));
            }
        }


        // команда открытия файла по двойному клику
        private RelayCommand _openFileInSpecificProgramCommand;

        public RelayCommand OpenFileInSpecificProgramCommand 
        {
            get
            {
                return _openFileInSpecificProgramCommand ??
                  (_openFileInSpecificProgramCommand = new RelayCommand(obj =>
                  {
                  _dialogService.ShowMessage("Двойной клик");
                  }));
            }
        }
    
    
    
    }
}
