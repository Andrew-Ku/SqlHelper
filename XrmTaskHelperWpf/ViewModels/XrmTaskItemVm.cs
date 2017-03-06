using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XrmTaskHelperWpf.ViewModels
{
    public class XrmTaskItemVm
    {
        public XrmTaskItemVm()
        {
           
        }

        public int Id { get; set; }

        public int TaskId { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Заметка")]
        public string Note { get; set; }

        [DisplayName("Дата создания")]
        public string CreateDate { get; set; }

        [DisplayName("Относительный путь")]
        public string Path { get; set; }

        [Display(Name = "Не найден на диске")]
        public bool IsNotFound { get; set; }

        public string IconSource { get; set; }


    }
}
