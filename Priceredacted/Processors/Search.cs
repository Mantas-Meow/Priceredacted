using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Search;

namespace Priceredacted.Processors
{
    class SearchAndFind
    {

        public static string AddData(Product productToBeAdded)
        {
            List<Product> Products = JsonConvert.DeserializeObject<List<Product>>(System.IO.File.ReadAllText(MainWindow.path));
            if (Products == null)
            {
                Products = new List<Product>();
            }
            Products.Add(productToBeAdded);
            return JsonConvert.SerializeObject(Products.ToArray());
            //System.IO.File.WriteAllText(path, json);
            //MessageBox.Show("Data saved!");
        }

        public static IEnumerable<Product> SearchForProduct(string query)
        {
            IEnumerable<Product> UnfilteredProducts = JsonConvert.DeserializeObject<List<Product>>(System.IO.File.ReadAllText(MainWindow.path));
            IEnumerable<Product> FilteredProducts = null;
            if (query == "")
            {
                FilteredProducts = UnfilteredProducts;
            }
            else
            {
                FilteredProducts = from pr in UnfilteredProducts where pr.Shop.ToLower().Contains(query) || pr.Group.ToLower().Contains(query) || pr.Name.ToLower().Contains(query) || pr.PriceUnit.ToLower().Contains(query) || pr.Price.ToLower().Contains(query) select pr;
            }
            return FilteredProducts;
        }
    }
}
