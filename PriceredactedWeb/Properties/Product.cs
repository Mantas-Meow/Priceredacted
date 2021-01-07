using static Priceredacted.Tools.Utils;

namespace Priceredacted.Properties
{
    public struct Product
    {
        public int Id { get; set; }
        public Shops Shop { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string PriceUnit { get; set; }
        public string Price { get; set; }
        
        //public Shops ShopEnum { get; set; }        
    }
}
