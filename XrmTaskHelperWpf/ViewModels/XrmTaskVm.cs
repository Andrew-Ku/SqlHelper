using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelperWpf.ViewModels
{
    public class XrmTaskVm
    {
        public XrmTaskVm()
        {
            Items = new List<XrmTaskItemVm>();
          
        }

        [Display(Name = "Код")]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Заметка")]
        public string Note { get; set; }

        [Display(Name = "Дата создания")]
        public string CreateDate { get; set; }

        [Display(Name = "Дата Выполнения")]
        public string CompleteDate { get; set; }

        [Display(Name = "Не найден на диске")]
        public bool IsNotFound { get; set; }

        public string IconSource { get; set; }

        [Display(Name = "Узел раскрыт/закрыт")]
        public bool IsExpanded { get; set; }
    

        public List<XrmTaskItemVm> Items { get; set; }
    }
}
