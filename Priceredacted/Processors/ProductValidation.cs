using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priceredacted.Processors
{
    class ProductValidation
    {
        public static bool ValidateProduct(List<Product> Products, Product ToAdd)
        {
            foreach (Product pr in Products)
            {
                if (pr.Name == ToAdd.Name && pr.Category == ToAdd.Category && pr.Shop == ToAdd.Shop && pr.PriceUnit == ToAdd.PriceUnit) return false;

            }
            return true;
        }

        public static Product AddProductID(List<Product> Products, Product ToAdd)
        {
            var ProductsInOrder = Products.OrderBy(Products => Products.Id);
            if (ProductsInOrder.Last().Id == 0)
            {
                ToAdd.Id = ((int)ToAdd.Shop * 100000) + 1;
            }
            else
            {
                ToAdd.Id = ProductsInOrder.Last().Id + 1;
            }
            return ToAdd;
        }

        public static Product AddProductID(Product ToAdd)
        {
            ToAdd.Id = ((int)ToAdd.Shop * 100000) + 1;
            return ToAdd;
        }
    }
}
