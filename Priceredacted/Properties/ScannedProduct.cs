using System;
using System.Collections.Generic;
using System.Text;
using static Priceredacted.Tools.Utils;

namespace Priceredacted.Properties
{
    public class ScannedProduct
    {
        public Shops Shop { get; set; }
        public string Name { get; set; }
        public string PriceUnit { get; set; }
        public string Price { get; set; }
        public string Comapared { get; set; }
    }
}
