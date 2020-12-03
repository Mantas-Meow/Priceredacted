using Priceredacted.Interfaces;
using Priceredacted.Models;
using Priceredacted.Properties;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Priceredacted.Processors
{
    class MainWindowLogic : IMainWindowLogic
    {
        public UserData currentUser;

        public void AddProduct(Product product)
        {
            List<List<Product>> productsList = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(Tools.Utils.ProductsPath);
            List<List<Product>> productsAll = SearchAndFind.AddData(product, productsList);
            DataProcessor.SaveJson(productsAll, Tools.Utils.ProductsPath);
            product.Id = 5;
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

        public void SaveReceipt()
        {
            List<Receipt> ReceiptsList = (List<Receipt>)DataProcessor.LoadJson<Receipt>(Tools.Utils.ReceiptsPath);
            List<ItemsInReceipt> InRec = (List<ItemsInReceipt>)DataProcessor.LoadJson<ItemsInReceipt>(Tools.Utils.ItemsInReceiptPath);
            (List<Receipt> ReceiptsAll, List<ItemsInReceipt> InRecAll) = ProductEditor.SaveReceipt(ReceiptsList, currentUser,InRec);
            DataProcessor.SaveJson(ReceiptsAll, Tools.Utils.ReceiptsPath);
            DataProcessor.SaveJson(InRecAll, Tools.Utils.ItemsInReceiptPath);
        }
    }
}
