using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Processors
{
    class ProductEditor
    {
        static List<ScannedProduct> ScannedProducts = new List<ScannedProduct>();
        private static string resultStr;

        public static string ComparePrices(string path)
        {
            PriceComparer.ComparePrices(path,ScannedProducts);
            resultStr = SProductsToString(ScannedProducts, resultStr);
            return resultStr; 
        }

        public static string FilterScanned(string input, string path)
        {
            ClearProducts();
            ScanFilter.Filter(input, path, ScannedProducts);
            resultStr = SProductsToString(ScannedProducts);
            return resultStr;
        }

        private static void ClearProducts()
        {
            ScannedProducts.Clear();
            resultStr = null;
        }

        private static string SProductsToString(List<ScannedProduct> SProducts, string resultStr = null)
        {
            foreach (ScannedProduct Pr in SProducts)
            {
                resultStr += Pr.Shop + ": " + Pr.Name + ' ' + Pr.PriceUnit + ' ' + Pr.Price + '€' + "\t\t" + Pr.Comapared + '\n';
            }
            return resultStr;
        }
    }
}
