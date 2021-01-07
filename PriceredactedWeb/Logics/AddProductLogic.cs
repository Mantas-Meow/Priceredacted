using Priceredacted.Processors;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Priceredacted.Tools.Utils;

namespace Priceredacted.Logics
{
    class AddProductLogic
    {
        public void AddProduct(Product Pr)
        {
            //IEnumerable<IEnumerable<Product>> products = DataProcessor.LoadJson<IEnumerable<Product>>(Tools.Utils.ProductsPath);
            IEnumerable<IEnumerable<Product>> products = DataProcessor.LoadJson<IEnumerable<Product>>(null);
            IEnumerable<Product> filteredProducts = new List<Product>();
            filteredProducts = products.SelectMany(iepr => iepr.Where(Prod => 
                                       Prod.Name == Pr.Name
                                       && Prod.PriceUnit == Pr.PriceUnit
                                       && Prod.Category == Pr.Category
                                       && Prod.Shop == Pr.Shop));

            ScannedProduct pr = new ScannedProduct()
            {
                Shop = Pr.Shop,
                Name = Pr.Name,
                PriceUnit = Pr.PriceUnit,
                Price = Convert.ToDouble(Pr.Price),
                Id = (from fil in filteredProducts
                         select fil.Id).First()
            };
            ProductEditor.AddProducts(pr);
        }

        public string ComparePrices()
        {
            // return ProductEditor.ComparePrices(Tools.Utils.ProductsPath);
            return ProductEditor.ComparePrices(null);
        }

    }
}
