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
        private static string[] tempStr;        //use struct, perkelti i struct

        public static void Filter (string input, string path, List<ScannedProduct> SProducts)
        {
            tempStr = null;            
            tempStr = input.prepareText();
            SelectShopAndFilter(path, SProducts);
            //return resultStr;
        } 
        
        private static void SelectShopAndFilter(string path, List<ScannedProduct> SProducts)
        {
            string[] Shops = new string[] { "MAXIMA", "LIDL", "IKI", "RIMI", "NORFA"};
            string ShopResult = Shops.FirstOrDefault<string>(s => tempStr[0].ToUpper().Contains(s));
            switch (ShopResult)
            {
                case "MAXIMA":
                    tempStr[0] = "xxx";
                    ScanMaxima(path, SProducts);
                    break;

                case "LIDL":
                    tempStr[0] = "xxx";
                    ScanLidl(path, SProducts);
                    break;

                case "IKI":
                    tempStr[0] = "xxx";
                    ScanIki();
                    break;

                case "RIMI":
                    tempStr[0] = "xxx";
                    ScanRimi();
                    break;

                case "NORFA":
                    tempStr[0] = "xxx";
                    ScanNorfa();
                    break;

                default:
                    resultStr = "Could not read the shop!";
                    break;
            }
        }

        private static void ScanMaxima(string path, List<ScannedProduct> SProducts)
        {           
            tempStr.PickProducts((Shops)1,path,SProducts); //  TO BE WORKED ON
            /*foreach (string line in tempStr)
            {
                string query = line.ToLower();
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(query,MainWindowLogic.path);
                foreach(Product pr in filtered)
                {
                    if (pr.Shop == "Maxima")
                    resultStr += pr.Name + ' ' + pr.Price + '\n';
                }
            }*/
            

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

        private static void ScanNorfa()
        {

        }

        private static void ScanRimi()
        {

        }

        private static void ScanIki()
        {

        }
    }
}
