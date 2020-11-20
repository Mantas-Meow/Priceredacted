using Priceredacted.Processors;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using static Priceredacted.Tools.Utils;

namespace Priceredacted.Logics
{
    class AddProductLogic
    {
        public void AddProduct(Shops shop,
                string name, string priceUnit, string price)
        {
            ScannedProduct pr = new ScannedProduct()
            {
                Shop = shop,
                Name = name,
                PriceUnit = priceUnit,
                Price = Convert.ToDouble(price)
            };
            ProductEditor.AddProducts(pr);
        }

        public string ComparePrices()
        {
            return ProductEditor.ComparePrices(Tools.Utils.ProductsPath);
        }

    }
}
