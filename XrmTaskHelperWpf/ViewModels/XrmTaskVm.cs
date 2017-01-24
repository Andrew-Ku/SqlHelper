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
        public XrmTaskVm(XrmTask model)
        {
            Id = model.Id;
            Name = model.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
