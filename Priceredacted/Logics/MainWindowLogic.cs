using Priceredacted.Interfaces;
using Priceredacted.Properties;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;


namespace Priceredacted.Processors
{
    class MainWindowLogic : IMainWindowLogic
    {
        public static string selectedFile;

        public void AddProduct(Product product)
        {
            List<List<Product>> productsList = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(Tools.Utils.ProductsPath);
            List<List<Product>> productsAll = SearchAndFind.AddData(product, Tools.Utils.ProductsPath, productsList);
            DataProcessor.SaveJson(productsAll, Tools.Utils.ProductsPath);
        }

        public Product CreateProduct(Tools.Utils.Shops shop, string group,
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

        public void SaveToProductsJson<T>(IEnumerable<T> objects)
        {
            DataProcessor.SaveJson<T>(objects, Tools.Utils.ProductsPath);
        }

        public string ScanImage(string selectedFile)
        {
            return ImageRecognition.GetTextFromImage(imagePath: selectedFile);
        }

        public IEnumerable<Product> SearchProducts(string query, string preferredShop)
        {
            IEnumerable<IEnumerable<Product>> products = DataProcessor.LoadJson <IEnumerable<Product>>(Tools.Utils.ProductsPath);
            return SearchAndFind.SearchForProduct(query, preferredShop, products);
        }
        public IEnumerable<T> LoadFromProductsJson<T>()
        {
            return DataProcessor.LoadJson<T>(Tools.Utils.ProductsPath);
        }
        public void Clear()
        {
            ProductEditor.ClearProducts();
        }
    }
}
