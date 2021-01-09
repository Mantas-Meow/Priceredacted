using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Priceredacted.ExtensionMethods;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class ScanFilter
    {
        private static string[] tempStr;       

        public static void Filter (string input, string path, List<ScannedProduct> SProducts)
        {
            tempStr = null;            
            tempStr = input.prepareText();
            SelectShopAndFilter(path, SProducts);
        } 
        
        private static void SelectShopAndFilter(string path, List<ScannedProduct> SProducts)
        {
            string[] Shops = new string[] { "MAXIMA", "LIDL", "PALINK", "RIMI", "NORFA"};
            string ShopResult = Shops.FirstOrDefault<string>(s => tempStr[0].ToUpper().Contains(s));
            switch (ShopResult)
            {
                case "MAXIMA":
                    tempStr[0] = "xxx";
                    Scan(path, SProducts);
                    break;

                case "LIDL":
                    tempStr[0] = "xxx";
                    ScanLidl(path, SProducts);
                    break;

                case "PALINK":
                    tempStr[0] = "xxx";
                    Scan(path, SProducts);
                    break;

                case "RIMI":
                    tempStr[0] = "xxx";
                    Scan(path, SProducts);
                    break;

                case "NORFA":
                    tempStr[0] = "xxx";
                    Scan(path, SProducts);
                    break;

                default:
                    ScannedProduct Spr = new ScannedProduct(){Name = "Could not detect Shop!"};
                    SProducts.Add(Spr);
                    break;
            }
        }

        private static void Scan(string path, List<ScannedProduct> SProducts)
        {
            for (int i = 0; i < tempStr.Length; i++)
            {
                if (tempStr[i].Length > 18)
                {
                    tempStr[i] = tempStr[i].Remove(tempStr[i].Length - 8, 8);
                }
            }
            tempStr.PickProducts((Shops)1,path,SProducts);          
        }

        private static void ScanLidl(string path, List<ScannedProduct> SProducts)
        {
            for (int i=0; i<tempStr.Length;i++)
            {
                if (tempStr[i].Length>18)
                {
                    string temp = tempStr[i];
                    temp = temp.Remove(0,7);
                    tempStr[i] = temp.Remove(temp.Length-8,7);
                }
            }
            tempStr.PickProducts((Shops)2, path, SProducts);
        }
    }
}
