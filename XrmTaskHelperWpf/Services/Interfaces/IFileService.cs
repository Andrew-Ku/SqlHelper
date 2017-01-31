using System.Collections.Generic;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelperWpf.Services.Interfaces
{
    interface IFileService<T> where T : class
    {
        T Open(string filename);
        void Save(string filename, T XrmTaskList);
    }
}
