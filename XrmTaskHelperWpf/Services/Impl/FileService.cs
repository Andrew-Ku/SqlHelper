using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XrmTaskHelperWpf.Services.Interfaces;

namespace XrmTaskHelperWpf.Services.Impl
{
    public class FileService : IFileService
    {
        public T OpenJson<T>(string filename)
        {
            var file = File.ReadAllText(filename);

            try
            {
                return JsonConvert.DeserializeObject<T>(file);
            }
            catch (Exception e)
            {

                return default(T);
            }
        }

        public void SaveJson<T>(string filename, T obj)
        {
            var jsonObjStr = JsonConvert.SerializeObject(obj);

            File.WriteAllText(filename, jsonObjStr);
        }

        public bool IsExistFile(string path)
        {
            return File.Exists(path);
        }  
        
        public bool IsExistDirectory(string path)
        {
            return Directory.Exists(path);
        }

        public void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
        }

        public void OverWrite(string path)
        {
            throw new NotImplementedException();
        }


        public List<DirectoryInfo> GetDirectories(string path)
        {
            var info = new DirectoryInfo(path);

            return info.GetDirectories().ToList();
        }

        public List<FileInfo> GetFiles(string path)
        {
            var info = new DirectoryInfo(path);
            var dirs = info.GetDirectories();
            return  info.GetFiles().ToList();
        }
    }
}
