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
        public static List<ComparedProduct> ComparePrices(string path, List<ScannedProduct> SProducts)
        {
            List<ComparedProduct> comparedProducts = new List<ComparedProduct>();
            foreach (ScannedProduct SPr in SProducts)
            {
                SPr.Comapared = null;
                bool found = false;
                IEnumerable<Product> filtered = SearchAndFind.SearchForProduct(SPr.Name.ToLower().Trim(), path);
                foreach (Product pr in filtered)
                {
                    
                    if (pr.Shop != SPr.Shop)
                    {
                        found = true;
                        //SPr.Comapared += Enum.GetName(typeof(Shops),pr.Shop) + ": " + pr.Price + "€ /";
                        double price = Convert.ToDouble(pr.Price);
                        comparedProducts.Add(new ComparedProduct(){Shop = Enum.GetName(typeof(Shops),pr.Shop), Price = price, Compared = price - SPr.Price});
                    }
                    
                }
                if (!found){
                    comparedProducts.Add(new ComparedProduct(){Shop = "-", Price = 0, Compared = 0});
                }
            } 
            return comparedProducts;    
        }
    }
}
