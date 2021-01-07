#nullable disable

namespace PriceredactedWeb.Models
{
    public partial class SearchParamsDTO
    {
        public string Shop { get; set; }
        public string ItemGroup { get; set; }
        public string Name { get; set; }
        public string PriceUnit { get; set; }
        public string Price { get; set; }
    }
}
