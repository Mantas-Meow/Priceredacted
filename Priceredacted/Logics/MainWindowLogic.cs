using Priceredacted.Interfaces;
using Priceredacted.Search;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;

namespace Priceredacted.Processors
{
    class MainWindowLogic : IMainWindowLogic
    {
        public static string selectedFile;

        public string AddProduct(Product product)
        {
            return SearchAndFind.AddData(product, Tools.Utils.ProductsPath);
        }

        public Product CreateProduct(string shop, string group,
                string name, string priceUnit, string price)
        {
            Product pr = new Product()
            {
                Shop = shop,
                Group = group,
                Name = name,
                PriceUnit = priceUnit,
                Price = price
            };
            return pr;
        }

        public string FilterText(string input)
        {
            return ScanFilter.Filter(input, Tools.Utils.ProductsPath);
        }

        public string ComparePrices(string input)
        {
            return PriceComparer.comparePrices(input, Tools.Utils.ProductsPath);
        }

        public void SaveData(string json)
        {
            System.IO.File.WriteAllText(Tools.Utils.ProductsPath, json);
        }

        public string ScanImage(string selectedFile)
        {
            return ImageRecognition.GetTextFromImage(selectedFile);
        }

        public IEnumerable<Product> SearchProducts(string query)
        {
            return SearchAndFind.SearchForProduct(query, Tools.Utils.ProductsPath);
        }
    }
}
