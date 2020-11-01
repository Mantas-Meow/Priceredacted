using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Interfaces
{
    interface IMainWindowLogic
    {
        public static string selectedFile;

        public string ScanImage(string selectedFile);
        public IEnumerable<Product> SearchProducts(string query);
        public Product CreateProduct(string shop, string group,
                string name, string priceUnit, string price);
        public string AddProduct(Product product);
        public void SaveData(string json);
    }
}
