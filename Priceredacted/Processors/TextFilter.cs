using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Priceredacted.Processors
{
    class TextFilter
    {
        private static string[] tempStr;
        private static string resultStr;

        public static string Filter (string input)
        {
            tempStr = null;
            resultStr = null;
            fixText(input);
            //scanMaxima();
            foreach (string line in tempStr)
            {
                resultStr += line + '\n';
            }
                return resultStr;
        } 


        private static void fixText(string input)
        {
            string temp = Regex.Replace(input, @"[^0-9a-zA-Z. '\n'ąčęėįšųūžĄČĘĖĮŠŲŪŽ]+", "");
            tempStr = temp.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static void scanMaxima()
        {
            foreach (string line in tempStr)
            {
                string query = line.ToLower();
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(query);
                foreach(Product pr in filtered)
                {
                    resultStr += pr.Name + ' ' + pr.Price + '\n';
                }
            }
            

        }



    }
}
