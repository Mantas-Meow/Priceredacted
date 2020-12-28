using Priceredacted.Interfaces;
using Priceredacted.Models;
using Priceredacted.Properties;
using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Priceredacted.Processors
{
    class ScanPageLogic : IScanPageLogic
    {
        public UserData currentUser;

        public void AddProduct(Product product)
        {
            // List<List<Product>> productsList = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(Tools.Utils.ProductsPath);
            List<List<Product>> productsList = (List<List<Product>>) DataProcessor.LoadJson<List<Product>>(null);
            List<List<Product>> productsAll = ProductsProcessor.AddData(product, productsList);
            // DataProcessor.SaveJson(productsAll, Tools.Utils.ProductsPath);
            DataProcessor.SaveJson(productsAll, null);
            product.Id = 5;
        }

        public Task<string> FilterText(string input)
        {
            // return Task.Run(() => ProductEditor.FilterScanned(input, Tools.Utils.ProductsPath));
            return Task.Run(() => ProductEditor.FilterScanned(input, null));
        }

        public Task<string> ComparePrices()
        {
            // return Task.Run(() => ProductEditor.ComparePrices(Tools.Utils.ProductsPath));
            return Task.Run(() => ProductEditor.ComparePrices(null));
        }

        public void SaveToProductsJson<T>(IEnumerable<T> objects)
        {
            // DataProcessor.SaveJson<T>(objects, Tools.Utils.ProductsPath);
            DataProcessor.SaveJson<T>(objects, null);
        }
        public IEnumerable<Product> SearchProducts(string query, string preferredShop)
        {
            // IEnumerable<IEnumerable<Product>> products = DataProcessor.LoadJson <IEnumerable<Product>>(Tools.Utils.ProductsPath);
            IEnumerable<IEnumerable<Product>> products = DataProcessor.LoadJson <IEnumerable<Product>>(null);
            return SearchAndFind.SearchForProduct(query, preferredShop, products);
        }

        public Task<string> ScanImageAsync(string selectedFile) => 
            Task.Run(() => ImageRecognition.GetTextFromImage(imagePath: selectedFile));

        public IEnumerable<T> LoadFromProductsJson<T>() => 
            // DataProcessor.LoadJson<T>(Tools.Utils.ProductsPath);
            DataProcessor.LoadJson<T>(null);

        public void Clear() => ProductEditor.ClearProducts();

        public void SaveReceipt()
        {
            //List<Receipt> ReceiptsList = (List<Receipt>)DataProcessor.LoadJson<Receipt>(Tools.Utils.ReceiptsPath);
            List<Receipt> ReceiptsList = (List<Receipt>)DataProcessor.LoadJson<Receipt>(null);
            // List<ItemsInReceipt> InRec = (List<ItemsInReceipt>)DataProcessor.LoadJson<ItemsInReceipt>(Tools.Utils.ItemsInReceiptPath);
            List<ItemsInReceipt> InRec = (List<ItemsInReceipt>)DataProcessor.LoadJson<ItemsInReceipt>(null);
            (List<Receipt> ReceiptsAll, List<ItemsInReceipt> InRecAll) = ProductEditor.SaveReceipt(ReceiptsList, currentUser,InRec);
            // DataProcessor.SaveJson(ReceiptsAll, Tools.Utils.ReceiptsPath);
            DataProcessor.SaveJson(ReceiptsAll, null);
            // DataProcessor.SaveJson(InRecAll, Tools.Utils.ItemsInReceiptPath);
            DataProcessor.SaveJson(InRecAll, null);
        }
    }
}
