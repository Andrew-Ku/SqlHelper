using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelperWpf.ViewModels
{
    public class XrmTaskItemVm
    {
        public int Id { get; set; }

        public int TaskId { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Заметка")]
        public string Note { get; set; }

        [DisplayName("Дата создания")]
        public DateTime CreateDate { get; set; }

        [DisplayName("Путь")]
        public string Path { get; set; }
    }
}
