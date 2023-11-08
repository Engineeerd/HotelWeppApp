namespace HotelWebApp.Models
{
    public class Property
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public Price price { get; set; }
        public string regionId { get; set; }
        public object listingFooter { get; set; }
        public object pinnedDetails { get; set; }
        public Availability availability { get; set; }
        public PropertyImage propertyImage { get; set; }
        public DestinationInfo destinationInfo { get; set; }
        
    }
}
