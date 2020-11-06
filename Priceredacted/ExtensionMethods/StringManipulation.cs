using Priceredacted.Processors;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static Priceredacted.Tools.Utils;



namespace Priceredacted.ExtensionMethods
{
    public static class StringManipulation
    {
        public static string[] prepareText (this string input)
        {
            string temp = Regex.Replace(input, @"[^0-9a-zA-Z., \nąčęėįšųūžĄČĘĖĮŠŲŪŽ%]+", "");
            return seperateToLines(temp);
        }

        public static string [] seperateToLines (this string input)
        {
            string[] tempStr = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return tempStr;
        }
        
        public static string combineToString(this string [] input, string resultStr = null)
        {
            foreach (string line in input)
            {
                resultStr += line + '\n';
            }
            return resultStr;
        }

        public static void PickProducts(this string[] tempStr, Shops shop, string path, List<ScannedProduct> SProducts)
        {
            //resultStr += shop + '\n';
            foreach (string line in tempStr)
            {
                string query = line.ToLower().Trim();
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(query, path);
                foreach (Product pr in filtered)
                {
                    if (pr.Shop == shop)
                    {
                        ScannedProduct Spr = new ScannedProduct()
                        {
                            Shop = pr.Shop,
                            Name = pr.Name,
                            PriceUnit = pr.PriceUnit,
                            Price = Convert.ToDouble(pr.Price)
                        };
                        SProducts.Add(Spr);
                        //resultStr += pr.Name + " :" + pr.Price + " €\n";
                    }
                        
                }
            }
            //return resultStr;
        }
    }
}
