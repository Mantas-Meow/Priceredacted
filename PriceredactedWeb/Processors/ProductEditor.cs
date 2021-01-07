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

        public static List<ComparedProduct> ComparePrices(List<ScannedProduct> products, string path)
        {
            return PriceComparer.ComparePrices(path, products);
            //return SProductsToString(ScannedProducts); 
        }

        public static List<ScannedProduct> FilterScanned(string input, string path)
        {
            ClearProducts();
            ScanFilter.Filter(input, path, ScannedProducts);
            //resultStr = SProductsToString(ScannedProducts);
            return ScannedProducts;//resultStr;
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

        public static (List<Receipt>, List<ItemsInReceipt>) SaveReceipt(List<Receipt> Receipts, UserData CurrentUser, List<ItemsInReceipt> InRec)
        {
            if (Receipts == null)
            {
                Receipts = new List<Receipt>();
            }
            if (InRec == null)
            {
                InRec = new List<ItemsInReceipt>();
            }
            (Receipt newRec, List<ItemsInReceipt> NewInRec) = AddNewReceipt(CurrentUser, InRec);
            Receipts.Add(newRec);
            return (Receipts, NewInRec);
        }

        private static (Receipt, List<ItemsInReceipt>) AddNewReceipt(UserData CurrentUser, List<ItemsInReceipt> InRec)
        {
            Receipt newRec = new Receipt();

            newRec.Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            newRec.UserId = CurrentUser.Id;
            newRec.ReceiptId = Guid.NewGuid();
            foreach (ScannedProduct Pr in ScannedProducts)
            {
                InRec.Add(new ItemsInReceipt { ReceiptId = newRec.ReceiptId, ProductId = Pr.Id });
                newRec.Sum += Pr.Price;
            }
            return (newRec,InRec);
        }
    }
}
