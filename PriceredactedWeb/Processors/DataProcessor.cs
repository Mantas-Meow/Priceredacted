using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Processors
{
    static class DataProcessor
    {
        private static object _lock = new object();
        public static IEnumerable<T> LoadJson<T>(string path)
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(System.IO.File.ReadAllText(path));
        }
           
        public static void SaveJson<T>(IEnumerable<T> objects, string path)
        {

            lock (_lock)
            {
                string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
                System.IO.File.WriteAllText(path, json);
            }
        }
    }
}
