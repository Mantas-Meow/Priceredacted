using System;
using System.Collections.Generic;
using System.Text;
using Priceredacted.ExtensionMethods;
using Priceredacted.Search;

namespace Priceredacted.Processors
{
    class PriceComparer
    {
        private static string[] tempStr;
        private static string resultStr;


        public static string comparePrices(string input)
        {
            tempStr = null;
            resultStr = null;
            tempStr = input.seperateToLines();
            priceDifference();
            return resultStr;
        }

        private static void priceDifference()
        {
            //string shop = tempStr[0];//.Remove(tempStr[0].Length);
            //resultStr = shop;
            //tempStr[0] = ;
            bool n = false;
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
                query = query.Remove(query.IndexOf(":")-2);//, query.Length - query.IndexOf(":") - 1);
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(query, MainWindowLogic.path);


                foreach (Product pr in filtered)
                {                       
                    
                    if (pr.Shop != tempStr[0])
                    {
                        resultStr += pr.Shop + ' ' + pr.Price + "€ /";
                    }

                }
            }
        }

    }
}
