using System;
using System.Collections.Generic;
using System.Text;
using Priceredacted.ExtensionMethods;
using Priceredacted.Properties;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class PriceComparer
    {
        public static void ComparePrices(string path, List<ScannedProduct> SProducts)
        {
            foreach (ScannedProduct SPr in SProducts)
            {
                SPr.Comapared = null;
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(SPr.Name.ToLower().Trim(), path);
                foreach (Product pr in filtered)
                {
                    if (pr.Shop != SPr.Shop)
                    {
                        SPr.Comapared += Enum.GetName(typeof(Shops),pr.Shop) + ": " + pr.Price + "€ /";
                    }
                }
            }     
        }
    }
}
