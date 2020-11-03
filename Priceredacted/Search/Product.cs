using static Priceredacted.Tools.Utils;

namespace Priceredacted.Search
{
    struct Product
    {
        private string _shop;
        public Shops Shop { get; set; } 
        /*{
            get
            {
                return _shop;
            }
            set
            {

                /*_shop = value;
                switch (value.ToLower())
                {
                    case "maxima":
                        ShopEnum = Shops.Maxima;
                        break;
                    case "lidl":
                        ShopEnum = Shops.Lidl;
                        break;
                    case "iki":
                        ShopEnum = Shops.Iki;
                        break;
                    case "rimi":
                        ShopEnum = Shops.Rimi;
                        break;
                    case "norfa":
                        ShopEnum = Shops.Norfa;
                        break;
                    default:
                        ShopEnum = Shops.Default;
                        break;
                }
            }*/
        
        public string Group { get; set; }
        public string Name { get; set; }
        public string PriceUnit { get; set; }
        public string Price { get; set; }
        //public Shops ShopEnum { get; set; }        
    }
}
