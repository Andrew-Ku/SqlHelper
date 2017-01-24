using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelper.Domain.Entities
{
    [Description("Тэг")]
    public class Tag
    {
        public int Id { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }
    }
}
