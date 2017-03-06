using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace XrmTaskHelperWpf.ViewModels
{
    [ImplementPropertyChanged]
    public class InfoObjectVm
    {
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Дата создания")]
        public string CreateDate { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Заметка")]
        public string Note { get; set; }

        [Display(Name = "Дата Выполнения")]
        public string CompleteDate { get; set; }
    }
}
