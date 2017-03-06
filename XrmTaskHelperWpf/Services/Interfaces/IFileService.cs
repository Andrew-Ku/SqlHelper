using System.Collections.Generic;
using System.IO;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelperWpf.Services.Interfaces
{
    public interface IFileService
    {
        T OpenJson<T>(string filename);

        void SaveJson<T>(string filename, T XrmTaskList);

        bool IsExistFile(string path);

        bool IsExistDirectory(string path);
     
        void CreateFile(string path);

        void CreateDirectory(string path);

        void DeleteFile(string path);
      
        void DeleteDirectory(string path);

        void OverWrite(string path);

        List<DirectoryInfo> GetDirectories(string path);

        List<FileInfo> GetFiles(string path);
    }
}
