using Priceredacted.Models;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return SProductsToString(ScannedProducts); 
        }

        public static string FilterScanned(string input, string path)
        {
            ClearProducts();
            ScanFilter.Filter(input, path, ScannedProducts);
            resultStr = SProductsToString(ScannedProducts);
            return resultStr;
        }

        public static void AddProducts(ScannedProduct pr)
        {
            ScannedProducts.Add(pr);
        }

        public static void ClearProducts()
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

        public static List<Receipt> SaveReceipt(List<Receipt> Receipts, UserData CurrentUser)
        {
            if (Receipts == null)
            {
                Receipts = new List<Receipt>();
            }
            Receipt newRec = AddNewReceipt(CurrentUser);
            Receipts.Add(newRec);
            return Receipts;
        }

        private static Receipt AddNewReceipt(UserData CurrentUser)
        {
            Receipt newRec = new Receipt();

            newRec.Date = DateTime.Now;
            newRec.UserId = CurrentUser.Id;
            foreach (ScannedProduct Pr in ScannedProducts)
            {
                newRec.ProductId.Add(Pr.Id);
                newRec.Sum += Pr.Price;
            }
            return newRec;
        }
    }
}
