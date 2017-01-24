using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Core.Interfaces;

namespace XrmTaskHelper.Domain.Entities
{
    [Description("Задача")]
    public class XrmTask : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
