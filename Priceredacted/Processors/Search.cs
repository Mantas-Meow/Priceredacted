using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Properties;
using System.IO;
using System;
using System.Text.RegularExpressions;

namespace Priceredacted.Processors
{
    class SearchAndFind
    {
        public static List<List<Product>> AddData(Product productToBeAdded, string path, List<List<Product>> products)
        {
            //List<List<Product>> products = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(path);
            productToBeAdded.Price = Regex.Replace(productToBeAdded.Price, @",+", ".");
            if (products == null)
            {
                products = new List<List<Product>>();
            }
            foreach (List<Product> li in products)
            {
                if (li.First().Name[0] == productToBeAdded.Name[0])
                { 
                    li.Add(productToBeAdded);
                    return products;
                }
            }
            List<Product> newList = new List<Product>();
            newList.Add(productToBeAdded);
            products.Add(newList);
            return products;
        }
        public static IEnumerable<Product> SearchForProduct(string query, string preferredShop,
            IEnumerable<IEnumerable<Product>> unfilteredProducts)
        {
            IEnumerable<Product> filteredProducts = new List<Product>();
            filteredProducts = (from listpr in unfilteredProducts from pr in listpr select pr);

            if (preferredShop == "" || preferredShop == "Visos parduotuvės")
            {
                if (query == null)
                {
                    filteredProducts = (from listpr in unfilteredProducts from pr in listpr select pr).Distinct();
                }
                else
                {
                    filteredProducts = from iepr in unfilteredProducts
                                       from pr in iepr
                                       where /*pr.Shop == ((Shops)Enum.Parse(typeof(Shops), query)) 
                                            ||*/ pr.Group.ToLower().Contains(query)
                                       || pr.Name.ToLower().Contains(query)
                                       || pr.PriceUnit.ToLower().Contains(query)
                                       || pr.Price.ToLower().Contains(query)
                                       select pr;
                }
            }
            else
            {
                if (query == null)
                {
                    filteredProducts = (from listpr in unfilteredProducts from pr in listpr where pr.Shop.ToString() == preferredShop select pr).Distinct();
                }
                else
                {
                    filteredProducts = from iepr in unfilteredProducts 
                                       from pr in iepr 
                                       where /*pr.Shop == ((Shops)Enum.Parse(typeof(Shops), query)) 
                                            ||*/ (pr.Group.ToLower().Contains(query) 
                                       || pr.Name.ToLower().Contains(query) 
                                       || pr.PriceUnit.ToLower().Contains(query) 
                                       || pr.Price.ToLower().Contains(query))
                                       && pr.Shop.ToString() == preferredShop
                                       select pr;
                }
            }
            return filteredProducts;
        }

        public static IEnumerable<Product> SearchForProduct(string query, string path) /// need to separate data loading!
        {
            IEnumerable<IEnumerable<Product>> unfilteredProducts = DataProcessor.LoadJson<IEnumerable<Product>>(path);
            IEnumerable<Product> filteredProducts = new List<Product>();
            if (query == null)
            {
                filteredProducts = (from listpr in unfilteredProducts from pr in listpr select pr).Distinct();
            }
            else
            {
                filteredProducts = from iepr in unfilteredProducts
                                   from pr in iepr
                                   where /*pr.Shop == ((Shops)Enum.Parse(typeof(Shops), query)) 
                                            ||*/ pr.Group.ToLower().Contains(query)
                                   || pr.Name.ToLower().Contains(query)
                                   || pr.PriceUnit.ToLower().Contains(query)
                                   || pr.Price.ToLower().Contains(query)
                                   select pr;
            }
            return filteredProducts;
        }
    }
}
