using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Search;
using Priceredacted.UI;

namespace Priceredacted.Processors
{
    class AddUserData
    {
        public static string AddData(Product productToBeAdded)
        {
            List<Product> Data = JsonConvert.DeserializeObject<List<Product>>(System.IO.File.ReadAllText(RegisterForm.path));
            if (Data == null)
            {
                Data = new List<Product>();
            }
            Data.Add(productToBeAdded);
            return JsonConvert.SerializeObject(Data.ToArray());
        }
    }
}
