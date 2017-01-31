using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Core.Consts;
using XrmTaskHelper.Core.Interfaces;

namespace XrmTaskHelper.Domain.Entities
{
    [Description("Тэг")]
    public class Tag : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Тип")]
        public TagTypes Type { get; set; }

        [DisplayName("Дата создания")]
        public DateTime CreateDate { get; set; }
    }
}
