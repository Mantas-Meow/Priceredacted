using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Interfaces
{
    public interface IScanPageLogic
    {
        public static string selectedFile;
        public Task<string> ScanImageAsync(string selectedFile);
        public IEnumerable<Product> SearchProducts(string query, string preferredShop);
        public void AddProduct(Product product);
        public void SaveToProductsJson<T>(IEnumerable<T> objects);
        public IEnumerable<T> LoadFromProductsJson<T>();

        public Task<string> FilterText(string input);
    }
}
