using Priceredacted.Interfaces;
using Priceredacted.Properties;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Priceredacted.Processors
{
    class MainWindowLogic : IMainWindowLogic
    {
        public static string selectedFile;
        public UserData currentUser;

        public void AddProduct(Product product)
        {
            List<List<Product>> productsList = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(Tools.Utils.ProductsPath);
            List<List<Product>> productsAll = SearchAndFind.AddData(product, Tools.Utils.ProductsPath, productsList);
            DataProcessor.SaveJson(productsAll, Tools.Utils.ProductsPath);
        }

        public Product CreateProduct(Tools.Utils.Shops shop, string category,
                string name, string priceUnit, string price)
        {
            Product pr = new Product()
            {
                Shop = shop,
                Category = category,
                Name = name,
                PriceUnit = priceUnit,
                Price = price
            };
            return pr;
        }

        public Task<string> FilterText(string input)
        {
            return Task.Run(() => ProductEditor.FilterScanned(input, Tools.Utils.ProductsPath));
        }

        public Task<string> ComparePrices()
        {
            return Task.Run(() => ProductEditor.ComparePrices(Tools.Utils.ProductsPath));
        }

        public void SaveToProductsJson<T>(IEnumerable<T> objects)
        {
            DataProcessor.SaveJson<T>(objects, Tools.Utils.ProductsPath);
        }

        public Task<string> ScanImageAsync(string selectedFile)
        {
            return Task.Run(() => ImageRecognition.GetTextFromImage(imagePath: selectedFile));
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
