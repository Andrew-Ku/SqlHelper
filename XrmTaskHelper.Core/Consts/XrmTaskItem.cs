using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelper.Core.Consts
{
    public enum XrmTaskItemTypes
    {
        [Description("Каталог")]
        Directory,

        [Description("Изображение")]
        Image,

        [Description("Изображение")]
        Text
    }
}
