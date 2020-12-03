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
        public static List<List<Product>> AddData(Product productToBeAdded, List<List<Product>> products)
        {
            //List<List<Product>> products = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(path);
            productToBeAdded.Price = Regex.Replace(productToBeAdded.Price, @",+", ".");
            if (products == null)
            {
                products = new List<List<Product>>();
            }
            foreach (List<Product> li in products)
            {
                if (li.First().Shop == productToBeAdded.Shop)
                { 
                    if (ProductValidation.ValidateProduct(li, productToBeAdded))
                    {
                        productToBeAdded = ProductValidation.AddProductID(li, productToBeAdded);
                        li.Add(productToBeAdded);
                        return products;
                    }
                    return products;
                }
            }
            List<Product> newList = new List<Product>();
            productToBeAdded = ProductValidation.AddProductID(newList, productToBeAdded);
            newList.Add(productToBeAdded);
            products.Add(newList);
            return products;
        }
        public static IEnumerable<Product> SearchForProduct(string query, string preferredShop,
            IEnumerable<IEnumerable<Product>> unfilteredProducts)
        {
            IEnumerable<Product> filteredProducts = new List<Product>();

            if (preferredShop == "" || preferredShop == "Visos parduotuvės")
            {
                if (query == "")
                {
                    filteredProducts = unfilteredProducts.SelectMany(pr => pr);
                }
                else
                {
                    filteredProducts = unfilteredProducts.SelectMany(iepr => iepr.Where(pr => (pr.Category.ToLower().Contains(query)
                                       || pr.Name.ToLower().Contains(query)
                                       || pr.PriceUnit.ToLower().Contains(query)
                                       || pr.Price.ToLower().Contains(query))));
                }
            }
            else
            {
                if (query == "")
                {
                    filteredProducts = unfilteredProducts.SelectMany(iepr => iepr.Where(pr => pr.Shop.ToString() == preferredShop));
                }
                else
                {
                    filteredProducts = unfilteredProducts.SelectMany(iepr => iepr.Where(pr => (pr.Category.ToLower().Contains(query)
                                       || pr.Name.ToLower().Contains(query)
                                       || pr.PriceUnit.ToLower().Contains(query)
                                       || pr.Price.ToLower().Contains(query))
                                       && pr.Shop.ToString() == preferredShop));
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
                filteredProducts = unfilteredProducts.SelectMany(iepr => iepr.Where(pr => (pr.Category.ToLower().Contains(query)
                                       || pr.Name.ToLower().Contains(query)
                                       || pr.PriceUnit.ToLower().Contains(query)
                                       || pr.Price.ToLower().Contains(query))));
            }
            return filteredProducts;
        }
    }
}
