using System;
using System.Collections.Generic;

#nullable disable

namespace PriceredactedWeb.Models
{
    public partial class Product
    {
        public string Shop { get; set; }
        public string ItemGroup { get; set; }
        public string Name { get; set; }
        public string PriceUnit { get; set; }
        public string Price { get; set; }
        public int? Id { get; set; }
    }
}
