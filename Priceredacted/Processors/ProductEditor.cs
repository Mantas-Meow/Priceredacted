using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Processors
{
    class ProductEditor
    {
        static List<ScannedProduct> ScannedProducts = new List<ScannedProduct>();

        public static string ComparePrices(string path)
        {
            PriceComparer.ComparePrices(path,ScannedProducts);
            return SProductsToString(ScannedProducts);
        }

        public static string FilterScanned(string input, string path)
        {
            ScanFilter.Filter(input, path, ScannedProducts);
            return SProductsToString(ScannedProducts);
        }

        public static void ClearProducts()
        {
            ScannedProducts.Clear();
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
