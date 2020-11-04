using Priceredacted.Interfaces;
using Priceredacted.Properties;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class MainWindowLogic : IMainWindowLogic
    {
        public static string selectedFile;

        public string AddProduct(Product product)
        {
            return SearchAndFind.AddData(product, Tools.Utils.ProductsPath);
        }

        public Product CreateProduct(Shops shop, string group,
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
            return ProductEditor.FilterScanned(input, Tools.Utils.ProductsPath);
        }

        public string ComparePrices()
        {
            return ProductEditor.ComparePrices(Tools.Utils.ProductsPath);
        }

        public void SaveData(string json)
        {
            System.IO.File.WriteAllText(Tools.Utils.ProductsPath, json);
        }

        public string ScanImage(string selectedFile)
        {
            return ImageRecognition.GetTextFromImage(selectedFile);
        }

        public IEnumerable<Product> SearchProducts(string query, string preferredShop)
        {
            return SearchAndFind.SearchForProduct(query, Tools.Utils.ProductsPath, preferredShop);
        }
    }
}
