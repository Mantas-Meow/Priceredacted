using Priceredacted.Processors;
using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


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

        public static string pickProducts(this string[] tempStr, string shop, string path, string resultStr = null)
        {
            resultStr = shop + '\n';
            foreach (string line in tempStr)
            {
                string query = line.ToLower().Trim();
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(query, path);
                foreach (Product pr in filtered)
                {
                    if (pr.Shop == shop)
                        resultStr += pr.Name + " :" + pr.Price + " €\n";
                }
            }
            return resultStr;
        }
    }
}
