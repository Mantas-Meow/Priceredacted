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

        public static string Filter (string input, string path)
        {
            tempStr = null;
            resultStr = null;
            
            tempStr = input.prepareText();
            selectShopAndFilter(path);
            return resultStr;
        } 
        
        private static void selectShopAndFilter(string path)
        {
            string[] Shops = new string[] { "MAXIMA", "LIDL", "IKI", "RIMI", "NORFA"};
            string ShopResult = Shops.FirstOrDefault<string>(s => tempStr[0].ToUpper().Contains(s));
            switch (ShopResult)
            {
                case "MAXIMA":
                    tempStr[0] = "xxx";
                    scanMaxima(path);
                    break;

                case "LIDL":
                    tempStr[0] = "xxx";
                    scanLidl(path);
                    break;

                case "IKI":
                    tempStr[0] = "xxx";
                    scanIki();
                    break;

                case "RIMI":
                    tempStr[0] = "xxx";
                    scanRimi();
                    break;

                case "NORFA":
                    tempStr[0] = "xxx";
                    scanNorfa();
                    break;

                default:
                    resultStr = "Could not read the shop!";
                    break;
            }
        }

        private static void scanMaxima(string path)
        {           
            resultStr = tempStr.pickProducts("Maxima", path); //  TO BE WORKED ON
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

        private static void scanLidl(string path)
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
            resultStr = tempStr.pickProducts("Lidl", path);
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
