using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelper.Core.Consts
{
      public static class Paths
    {
        public const string TasksDirectory = "Tasks";
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

    public static class IconPath
    {
        public const string Task = "/Resources/Images/task.png";
        public const string Pdf = "/Resources/Images/pdf.png";
        public const string Txt = "/Resources/Images/txt.png";
        public const string Sql = "/Resources/Images/sql.png";
        public const string Jpeg = "/Resources/Images/picture.png";
        public const string Png = "/Resources/Images/picture.png";
        public const string Bmp = "/Resources/Images/picture.png";
        public const string Docx = "/Resources/Images/doc.png";
        public const string Doc = "/Resources/Images/doc.png";
        public const string Xml = "/Resources/Images/xml.png";
        public const string Xlsx = "/Resources/Images/xls.png";
        public const string Xls = "/Resources/Images/xls.png";
        public const string Csv = "/Resources/Images/csv.png";
        public const string NotIcon = "/Resources/Images/notIcon.png";


        public static string GetIconPathByExtension(string extension)
        {
            var extensionLower = extension.Replace(".","").ToLower();

            switch (extensionLower)
            {
                case FileExtensions.Pdf : return Pdf;
                case FileExtensions.Txt: return Txt;
                case FileExtensions.Sql: return Sql;
                case FileExtensions.Jpeg: return Jpeg;
                case FileExtensions.Png: return Png;
                case FileExtensions.Bmp: return Bmp;
                case FileExtensions.Docx: return Docx;
                case FileExtensions.Doc: return Doc;
                case FileExtensions.Xml: return Xml;
                case FileExtensions.Xlsx: return Xlsx;
                case FileExtensions.Xls: return Xls;
                case FileExtensions.Csv: return Csv;
                default:
                    return NotIcon;

            }
        }


    }
}
