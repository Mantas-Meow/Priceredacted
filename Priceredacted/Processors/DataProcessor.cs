using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Processors
{
    static class DataProcessor
    {
        public static IEnumerable<T> LoadJson<T>(string path)
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(System.IO.File.ReadAllText(path));
        }
        public static void SaveJson<T>(IEnumerable<T> objects, string path)
        {
            string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
            System.IO.File.WriteAllText(path, json);
        }
    }
}
