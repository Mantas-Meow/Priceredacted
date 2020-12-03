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

        public static List<List<Receipt>> SaveReceipt(List<List<Receipt>> Receipts, UserData CurrentUser)
        {
            if (Receipts == null)
            {
                Receipts = new List<List<Receipt>>();
            }
            foreach (List<Receipt> rec in Receipts)
            {
                if (rec.First().UserId == CurrentUser.Id)
                {
                    Receipt newRec = AddNewReceipt(CurrentUser);
                    rec.Add(newRec);
                    return Receipts;
                }

            }
            List<Receipt> newList = new List<Receipt>();
            Receipt newRec1 = AddNewReceipt(CurrentUser);
            newList.Add(newRec1);
            Receipts.Add(newList);
            return Receipts;
        }

        private static Receipt AddNewReceipt(UserData CurrentUser)
        {
            Receipt newRec = new Receipt();
            DateTime CurrentTime = DateTime.Now;
            List<List<Product>> productsList = (List<List<Product>>)DataProcessor.LoadJson<List<Product>>(Tools.Utils.ProductsPath);
            foreach (ScannedProduct Pr in ScannedProducts)
            {
                newRec.Date = CurrentTime;
                newRec.UserId = CurrentUser.Id;
                newRec.ProductId=1;// = 1; //GetID(Pr, productsList);//Add(GetID(Pr, productsList)); 
                newRec.Sum += Pr.Price;
            }
            return newRec;
        }

        private static int GetID (ScannedProduct Pr, List<List<Product>> ProductsList)
        {
            foreach (List<Product> list in ProductsList)
            {
                if (list.First().Shop == Pr.Shop)
                {
                    foreach (Product PrId in list)
                    {
                        if (PrId.Name == Pr.Name) return PrId.Id;

                    }
                }
            }
            return 1;
        }
    }
}
