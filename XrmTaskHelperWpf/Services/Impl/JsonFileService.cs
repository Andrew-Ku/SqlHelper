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
    public class JsonFileService<T> : IFileService<T> where T : class // MyNote: Не тестил
    {
        public T Open(string filename)
        {
            var file = File.ReadAllText(filename);

            try
            {
                return JsonConvert.DeserializeObject<T>(file);
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public void Save(string filename, T obj)
        {
            var jsonObjStr = JsonConvert.SerializeObject(obj);

            File.WriteAllText(filename, jsonObjStr);
        }
    }
}
