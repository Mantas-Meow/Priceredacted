using static Priceredacted.Tools.Utils;

namespace Priceredacted.Properties
{
    struct Product
    {
        public Shops Shop { get; set; }

        public string Group { get; set; }
        public string Name { get; set; }
        public string PriceUnit { get; set; }
        public string Price { get; set; }
        //public Shops ShopEnum { get; set; }        
    }
}
