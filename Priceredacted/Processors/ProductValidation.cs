using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priceredacted.Processors
{
    class ProductValidation
    {
        public static bool ValidateProduct(List<Product> Products, Product ToAdd) => 
            !Products.Any(pr => pr.Name == ToAdd.Name && pr.Category == ToAdd.Category &&
            pr.Shop == ToAdd.Shop && pr.PriceUnit == ToAdd.PriceUnit);
    }
}
