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
        public void AddProduct(Product Pr)
        {
            ScannedProduct pr = new ScannedProduct()
            {
                Shop = Pr.Shop,
                Name = Pr.Name,
                PriceUnit = Pr.PriceUnit,
                Price = Convert.ToDouble(Pr.Price),
                Id = Pr.Id
            };
            ProductEditor.AddProducts(pr);
        }

        public string ComparePrices()
        {
            return ProductEditor.ComparePrices(Tools.Utils.ProductsPath);
        }

    }
}
