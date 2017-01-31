using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelper.Core.Consts
{
    public enum TagTypes
    {
        [Description("Главный объект")]
        Main,

        [Description("Дочерний объект")]
        Child
    }
}
