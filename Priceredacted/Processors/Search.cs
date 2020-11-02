using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Search;
using System.IO;

namespace Priceredacted.Processors
{
    class SearchAndFind
    {
        public static string AddData(Product productToBeAdded, string path)
        {
            List<List<Product>> Products = JsonConvert.DeserializeObject<List<List<Product>>>(System.IO.File.ReadAllText(path));
            if (Products == null)
            {
                Products = new List<List<Product>>();
            }
            foreach (List<Product> li in Products)
            {
                if (li.First().Name[0] == productToBeAdded.Name[0])
                {
                    li.Add(productToBeAdded);
                    return JsonConvert.SerializeObject(Products.ToArray());
                }
            }
            List<Product> newList = new List<Product>();
            newList.Add(productToBeAdded);
            Products.Add(newList);
            return JsonConvert.SerializeObject(Products.ToArray());
        }

        public static IEnumerable<Product> SearchForProduct(string query, string path)
        {
            IEnumerable<IEnumerable<Product>> UnfilteredProducts = JsonConvert.DeserializeObject<List<List<Product>>>(System.IO.File.ReadAllText(path));
            IEnumerable<Product> FilteredProducts = new List<Product>();

            if (query == "")
            {
                FilteredProducts = (from listpr in UnfilteredProducts from pr in listpr select pr).Distinct();
            }
            else
            {
                FilteredProducts = from iepr in UnfilteredProducts from pr in iepr where pr.Shop.ToLower().Contains(query) || pr.Group.ToLower().Contains(query) || pr.Name.ToLower().Contains(query) || pr.PriceUnit.ToLower().Contains(query) || pr.Price.ToLower().Contains(query) select pr;
            }
            return FilteredProducts;
        }
    }
}
