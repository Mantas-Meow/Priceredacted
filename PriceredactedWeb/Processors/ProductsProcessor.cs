using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Priceredacted.Processors
{
    delegate Product AddProductID(List<Product> Products, Product ToAdd);
    class ProductsProcessor
    {
        public static List<List<Product>> AddData(Product productToBeAdded, List<List<Product>> products)
        {
            AddProductID makeProductId = delegate (List<Product> Products, Product ToAdd)
            {
                if (Products.Count == 0)
                {
                    ToAdd.Id = ((int)ToAdd.Shop * 100000) + 1;
                }
                else
                {
                    ToAdd.Id = Products.Last().Id + 1;
                }
                return ToAdd;
            };

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
                        productToBeAdded = makeProductId(li, productToBeAdded);
                        li.Add(productToBeAdded);
                        return products;
                    }
                    return products;
                }
            }
            List<Product> newList = new List<Product>();
            productToBeAdded = makeProductId(newList, productToBeAdded);
            newList.Add(productToBeAdded);
            products.Add(newList);
            return products;
        }
    }
}
