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

    public static class FileExtensions
    {
        public const string Pdf = "pdf";
        public const string Txt = "txt";
        public const string Sql = "sql";
        public const string Jpeg = "jpeg";
        public const string Png = "png";
        public const string Bmp = "bmp";
        public const string Docx = "docx";
        public const string Doc = "doc";
        public const string Xml = "xml";
        public const string Xlsx = "xlsx";
        public const string Xls = "xls";
        public const string Csv = "csv";
    }
}
