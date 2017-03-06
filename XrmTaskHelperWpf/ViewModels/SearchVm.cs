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
    public class SearchVm
    {
         [Display(Name = "Название")]
         public string Name { get; set; }

         [Display(Name = "Тэг")]
         public string Tag { get; set; }
    }
}
