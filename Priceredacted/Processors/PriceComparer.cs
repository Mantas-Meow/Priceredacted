using System;
using System.Collections.Generic;
using System.Text;
using Priceredacted.ExtensionMethods;
using Priceredacted.Search;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class PriceComparer
    {
        private static string[] tempStr;
        private static string resultStr;

        public static string comparePrices(string input, string path)
        {
            tempStr = null;
            resultStr = null;
            tempStr = input.seperateToLines();
            priceDifference(path);
            return resultStr;
        }

        private static void priceDifference(string path)
        {
            /*bool n = false;
            foreach (string line in tempStr)
            {
                if (n)
                {
                    resultStr += '\n' + line + '\t';
                }
                else
                {
                    resultStr += line + '\t';
                    n = true;
                }
                    
                string query = line.ToLower().Trim();
                if (query.Length > 8)
                query = query.Remove(query.IndexOf(":")-2);
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(query, path);


                foreach (Product pr in filtered)
                {                       
                    
                    if (pr.Shop != tempStr[0])
                    {
                        resultStr += pr.Shop + ' ' + pr.Price + "€ /";
                    }

                }
            }*/
        }

    }
}
