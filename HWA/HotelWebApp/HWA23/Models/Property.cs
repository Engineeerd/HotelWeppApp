using System.Collections.Generic;

namespace HWA23.Models
{
    public class Property
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public List<object> featuredMessages { get; set; }
        public string name { get; set; }
        public Availability availability { get; set; }
        public PropertyImage propertyImage { get; set; }
        public DestinationInfo destinationInfo { get; set; }
        public object legalDisclaimer { get; set; }
        public object listingFooter { get; set; }
        public MapMarker mapMarker { get; set; }
        public Neighborhood neighborhood { get; set; }
        public OfferBadge offerBadge { get; set; }
        public OfferSummary offerSummary { get; set; }
        public object pinnedDetails { get; set; }
        public Price price { get; set; }
        public PriceAfterLoyaltyPointsApplied priceAfterLoyaltyPointsApplied { get; set; }
        public List<PropertyFee> propertyFees { get; set; }
        public Reviews reviews { get; set; }
        public SponsoredListing sponsoredListing { get; set; }
        public object star { get; set; }
        public object supportingMessages { get; set; }
        public string regionId { get; set; }
        public PriceMetadata priceMetadata { get; set; }
        public object saveTripItem { get; set; }
    }
}