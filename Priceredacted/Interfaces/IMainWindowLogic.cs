using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Interfaces
{
    interface IMainWindowLogic
    {
        public static string selectedFile;

        public string ScanImage(string selectedFile);
        public IEnumerable<Product> SearchProducts(string query, string preferredShop);
        public Product CreateProduct(Shops shop, string group,
                string name, string priceUnit, string price);
        public void AddProduct(Product product);
        public void SaveToProductsJson<T>(IEnumerable<T> objects);
        public IEnumerable<T> LoadFromProductsJson<T>();
    }
}
