using System;
using System.Collections.Generic;
using System.Text;
using Priceredacted.ExtensionMethods;
using Priceredacted.Properties;
using System.Linq;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class PriceComparer
    {
        public static List<ComparedProduct> ComparePrices(string path, List<ScannedProduct> SProducts)
        {
            List<ComparedProduct> comparedProducts = new List<ComparedProduct>();
            foreach (ScannedProduct SPr in SProducts)
            {
                SPr.Comapared = null;
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(SPr.Name.ToLower().Trim(), path);
                Product pr = null;
                try {
                    pr = filtered.Aggregate((i, j) => Convert.ToDouble(i.Price) < Convert.ToDouble(j.Price) ? i : j);
                }
                catch{
                    pr = null;
                }
                
                if (pr != null && pr.Shop != SPr.Shop)
                {
                    //SPr.Comapared += Enum.GetName(typeof(Shops),pr.Shop) + ": " + pr.Price + "€ /";
                    double price = Convert.ToDouble(pr.Price);
                    comparedProducts.Add(new ComparedProduct(){Shop = Enum.GetName(typeof(Shops),pr.Shop), Price = price, Compared = price - SPr.Price});
                }
                else comparedProducts.Add(new ComparedProduct(){Shop = "-", Price = 0, Compared = 0});
            } 
            return comparedProducts;    
        }
    }
}
