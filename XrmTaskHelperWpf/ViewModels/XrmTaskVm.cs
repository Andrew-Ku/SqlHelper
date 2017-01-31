using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelperWpf.ViewModels
{
    public class XrmTaskVm
    {
        public XrmTaskVm()
        {
            Items = new List<XrmTaskItemVm>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? CompleteDate { get; set; }

        public List<XrmTaskItemVm> Items { get; set; }
    }
}
