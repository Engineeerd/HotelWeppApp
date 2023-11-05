using System.Collections.Generic;

namespace HotelWebApp.Models
{
    public class Price
    {
        public string __typename { get; set; }
        // public List<Option> options { get; set; }
        public object priceMessaging { get; set; }
        public Lead lead { get; set; }
        // public StrikeOut strikeOut { get; set; }
        public List<DisplayMessage> displayMessages { get; set; }
        public string strikeOutType { get; set; }
        // public List<PriceMessage> priceMessages { get; set; }
        public string formatted { get; set; }
        public string accessibilityLabel { get; set; }
    }
}
