using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Priceredacted.ExtensionMethods;

namespace Priceredacted.Processors
{
    class ScanFilter
    {
        private static string[] tempStr;
        private static string resultStr;

        public static string Filter (string input)
        {
            tempStr = null;
            resultStr = null;
            tempStr = input.prepareText();
            selectShopAndFilter();
            //resultStr = tempStr.combineToString();
            return resultStr;
        } 

        /*private static void fixText(string input)
        {
            string temp = Regex.Replace(input, @"[^0-9a-zA-Z. \nąčęėįšųūžĄČĘĖĮŠŲŪŽ]+", "");
            tempStr = temp.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }*/
        
        private static void selectShopAndFilter()
        {
            string[] Shops = new string[] { "MAXIMA", "LIDL", "IKI", "RIMI", "NORFA"};
            string ShopResult = Shops.FirstOrDefault<string>(s => tempStr[0].ToUpper().Contains(s));
            switch (ShopResult)
            {
                case "MAXIMA":
                    scanMaxima();
                    break;

                case "LIDL":
                    scanLidl();
                    break;

                case "IKI":
                    scanIki();
                    break;

                case "RIMI":
                    scanRimi();
                    break;

                case "NORFA":
                    scanNorfa();
                    break;

                default:
                    resultStr = "Could not read the shop!";
                    break;
            }
        }

        private static void scanMaxima()
        {          
            resultStr = tempStr.pickProducts("Maxima");
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

        private static void scanLidl()
        {

        }

        private static void scanNorfa()
        {

        }

        private static void scanRimi()
        {

        }

        private static void scanIki()
        {

        }
    }
}
