using Priceredacted.Interfaces;
using Priceredacted.Search;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Processors
{
    class MainWindowLogic : IMainWindowLogic
    {
        public static string selectedFile;
        public static string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\Products.json";

        public string AddProduct(Product product)
        {
            return SearchAndFind.AddData(product, path);
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

        public void SaveData(string json)
        {
            System.IO.File.WriteAllText(path, json);
        }

        public string ScanImage(string selectedFile)
        {
            return ImageRecognition.GetTextFromImage(selectedFile);
        }

        public IEnumerable<Product> SearchProducts(string query)
        {
            return SearchAndFind.SearchForProduct(query, path);
        }
    }
}
