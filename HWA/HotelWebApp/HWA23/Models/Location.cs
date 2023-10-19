using HWA23.Models;

using System.Collections.Generic;

public class Action
{
    public string __typename { get; set; }
    public string actionType { get; set; }
    public object accessibility { get; set; }
    public Analytics analytics { get; set; }
}

public class Actions
{
    public string __typename { get; set; }
    public Primary primary { get; set; }
    public List<Secondary> secondaries { get; set; }
}

public class Amenity
{
    public string __typename { get; set; }
    public int id { get; set; }
}

public class Analytics
{
    public string __typename { get; set; }
    public string linkName { get; set; }
    public string referrerId { get; set; }
}

public class ApplyAction
{
    public string __typename { get; set; }
    public string primary { get; set; }
    public Action action { get; set; }
    public string accessibility { get; set; }
    public object badge { get; set; }
    public bool disabled { get; set; }
    public object icon { get; set; }
}

public class Attribute
{
    public string __typename { get; set; }
    public string type { get; set; }
}

public class Availability
{
    public string __typename { get; set; }
    public bool available { get; set; }
    public int? minRoomsLeft { get; set; }
}

public class Characteristics
{
    public string __typename { get; set; }
    public int min { get; set; }
    public int max { get; set; }
    public int step { get; set; }
    public List<Label> labels { get; set; }
}

public class Clickstream
{
    public string __typename { get; set; }
    public object searchResultsViewed { get; set; }
}

public class ClientSideAnalytics
{
    public string __typename { get; set; }
    public string linkName { get; set; }
    public string referrerId { get; set; }
}

public class CollapseAnalytics
{
    public string __typename { get; set; }
    public string linkName { get; set; }
    public string referrerId { get; set; }
}

public class CurrencyInfo
{
    public string __typename { get; set; }
    public string code { get; set; }
    public string symbol { get; set; }
}

public class Data
{
    public PropertySearch propertySearch { get; set; }
}

public class DeselectAnalytics
{
    public string __typename { get; set; }
    public string linkName { get; set; }
    public string referrerId { get; set; }
}

public class DestinationInfo
{
    public string __typename { get; set; }
    public DistanceFromDestination distanceFromDestination { get; set; }
    public string distanceFromMessaging { get; set; }
    public string regionId { get; set; }
}

public class Disclaimer
{
    public string __typename { get; set; }
    public string value { get; set; }
    public List<string> content { get; set; }
    public object title { get; set; }
}

public class DisplayMessage
{
    public string __typename { get; set; }
    public List<LineItem> lineItems { get; set; }
}

public class DistanceFromDestination
{
    public string __typename { get; set; }
    public string unit { get; set; }
    public double value { get; set; }
}

public class DropdownFilterOption
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string primary { get; set; }
    public object secondary { get; set; }
    public object icon { get; set; }
    public Analytics analytics { get; set; }
    public string value { get; set; }
    public object description { get; set; }
    public bool selected { get; set; }
    public bool disabled { get; set; }
    public bool @default { get; set; }
    public SelectAnalytics selectAnalytics { get; set; }
    public DeselectAnalytics deselectAnalytics { get; set; }
}

public class ExpandAnalytics
{
    public string __typename { get; set; }
    public string linkName { get; set; }
    public string referrerId { get; set; }
}

public class Expando
{
    public string __typename { get; set; }
    public int threshold { get; set; }
    public string collapseLabel { get; set; }
    public string expandLabel { get; set; }
    public CollapseAnalytics collapseAnalytics { get; set; }
    public ExpandAnalytics expandAnalytics { get; set; }
}

public class FallbackImage
{
    public string __typename { get; set; }
    public string url { get; set; }
}

public class Field
{
    public string __typename { get; set; }
    public string primary { get; set; }
    public object secondary { get; set; }
    public Action action { get; set; }
    public string id { get; set; }
    public object label { get; set; }
    public string placeholder { get; set; }
    public object selected { get; set; }
    public TypeaheadInfo typeaheadInfo { get; set; }
    public Icon icon { get; set; }
    public Analytics analytics { get; set; }
    public Expando expando { get; set; }
    public List<MultiSelectionOption> multiSelectionOptions { get; set; }
    public Range range { get; set; }
    public List<Option> options { get; set; }
    public List<TileMultiSelectionOption> tileMultiSelectionOptions { get; set; }
    public List<DropdownFilterOption> dropdownFilterOptions { get; set; }
}

public class FilterMetadata
{
    public string __typename { get; set; }
    public List<Amenity> amenities { get; set; }
    public List<Neighborhood> neighborhoods { get; set; }
    public PriceRange priceRange { get; set; }
}

public class FilterSection
{
    public string __typename { get; set; }
    public string title { get; set; }
    public List<Field> fields { get; set; }
}

public class Icon
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string description { get; set; }
    public object size { get; set; }
    public string token { get; set; }
    public object theme { get; set; }
}

public class IconTemp
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string description { get; set; }
}

public class Image
{
    public string __typename { get; set; }
    public string description { get; set; }
    public string url { get; set; }
}

public class Label
{
    public string __typename { get; set; }
    public string label { get; set; }
    public int value { get; set; }
}

public class LatLong
{
    public string __typename { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
}

public class Lead
{
    public string __typename { get; set; }
    public double amount { get; set; }
    public CurrencyInfo currencyInfo { get; set; }
    public string formatted { get; set; }
}

public class LineItem
{
    public string __typename { get; set; }
    public Disclaimer disclaimer { get; set; }
    public Price price { get; set; }
    public string role { get; set; }
    public object accessibilityLabel { get; set; }
    public object mark { get; set; }
    public object state { get; set; }
    public string value { get; set; }
    public object badge { get; set; }
}

public class Link
{
    public string __typename { get; set; }
    public ClientSideAnalytics clientSideAnalytics { get; set; }
    public Uri uri { get; set; }
}

public class LoyaltyInfo
{
    public string __typename { get; set; }
    public object saveWithPointsMessage { get; set; }
    public object saveWithPointsActionMessage { get; set; }
}

public class Map
{
    public string __typename { get; set; }
    public object subtitle { get; set; }
}

public class MapMarker
{
    public string __typename { get; set; }
    public string label { get; set; }
    public LatLong latLong { get; set; }
}

public class Message
{
    public string __typename { get; set; }
    public string message { get; set; }
    public string theme { get; set; }
    public string type { get; set; }
    public object mark { get; set; }
}

public class MultiSelectionOption
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string primary { get; set; }
    public object secondary { get; set; }
    public Icon icon { get; set; }
    public Analytics analytics { get; set; }
    public string value { get; set; }
    public string description { get; set; }
    public bool selected { get; set; }
    public bool disabled { get; set; }
    public bool @default { get; set; }
    public SelectAnalytics selectAnalytics { get; set; }
    public DeselectAnalytics deselectAnalytics { get; set; }
}

public class Neighborhood
{
    public string __typename { get; set; }
    public string name { get; set; }
    public string regionId { get; set; }
}

public class Neighborhood2
{
    public string __typename { get; set; }
    public string name { get; set; }
}

public class OfferBadge
{
    public string __typename { get; set; }
    public Primary primary { get; set; }
    public Secondary secondary { get; set; }
}

public class OfferSummary
{
    public string __typename { get; set; }
    public List<Message> messages { get; set; }
    public List<Attribute> attributes { get; set; }
}

public class Option
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string primary { get; set; }
    public object secondary { get; set; }
    public Icon icon { get; set; }
    public Analytics analytics { get; set; }
    public string value { get; set; }
    public object description { get; set; }
    public bool selected { get; set; }
    public bool disabled { get; set; }
    public bool @default { get; set; }
    public SelectAnalytics selectAnalytics { get; set; }
    public DeselectAnalytics deselectAnalytics { get; set; }
    public StrikeOut strikeOut { get; set; }
    public Disclaimer disclaimer { get; set; }
    public string formattedDisplayPrice { get; set; }
}

public class Price
{
    public string __typename { get; set; }
    public List<Option> options { get; set; }
    public object priceMessaging { get; set; }
    public Lead lead { get; set; }
    public StrikeOut strikeOut { get; set; }
    public List<DisplayMessage> displayMessages { get; set; }
    public string strikeOutType { get; set; }
    public List<PriceMessage> priceMessages { get; set; }
    public string formatted { get; set; }
    public string accessibilityLabel { get; set; }
}

public class PriceAfterLoyaltyPointsApplied
{
    public string __typename { get; set; }
    public List<Option> options { get; set; }
    public Lead lead { get; set; }
}

public class PriceMessage
{
    public string __typename { get; set; }
    public string value { get; set; }
}

public class PriceMetadata
{
    public string __typename { get; set; }
    public string discountType { get; set; }
    public RateDiscount rateDiscount { get; set; }
    public int? totalDiscountPercentage { get; set; }
}

public class PriceRange
{
    public string __typename { get; set; }
    public double max { get; set; }
    public double min { get; set; }
}

public class PricingScheme
{
    public string __typename { get; set; }
    public string type { get; set; }
}

public class Primary
{
    public string __typename { get; set; }
    public object primary { get; set; }
    public Action action { get; set; }
    public string text { get; set; }
    public string theme_temp { get; set; }
    public IconTemp icon_temp { get; set; }
    public object mark { get; set; }
}

public class PropertyFee
{
    public string __typename { get; set; }
    public string type { get; set; }
}

public class PropertyImage
{
    public string __typename { get; set; }
    public string alt { get; set; }
    public FallbackImage fallbackImage { get; set; }
    public Image image { get; set; }
    public int subjectId { get; set; }
}

public class PropertySearch
{
    public string __typename { get; set; }
    public FilterMetadata filterMetadata { get; set; }
    public UniversalSortAndFilter universalSortAndFilter { get; set; }
    public List<Property> properties { get; set; }
    public List<PropertySearchListing> propertySearchListings { get; set; }
    public Summary summary { get; set; }
    public SearchCriteria searchCriteria { get; set; }
    public ShoppingContext shoppingContext { get; set; }
    public Map map { get; set; }
    public Clickstream clickstream { get; set; }
}

public class PropertySearchListing
{
    public string __typename { get; set; }
}

public class Range
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string primary { get; set; }
    public object secondary { get; set; }
    public object icon { get; set; }
    public Analytics analytics { get; set; }
    public Selected selected { get; set; }
    public Characteristics characteristics { get; set; }
}

public class RateDiscount
{
    public string __typename { get; set; }
    public string description { get; set; }
}

public class ResultsSummary
{
    public string __typename { get; set; }
    public string accessibilityLabel { get; set; }
    public string value { get; set; }
    public Link link { get; set; }
}

public class ResultsTitleModel
{
    public string __typename { get; set; }
    public string header { get; set; }
}

public class RevealAction
{
    public string __typename { get; set; }
    public string primary { get; set; }
    public Action action { get; set; }
    public string accessibility { get; set; }
    public int badge { get; set; }
    public bool disabled { get; set; }
    public Icon icon { get; set; }
}

public class Reviews
{
    public string __typename { get; set; }
    public double score { get; set; }
    public int total { get; set; }
}

public class Root2
{
    public Data data { get; set; }
}

public class SearchCriteria
{
    public string __typename { get; set; }
    public object resolvedDateRange { get; set; }
}

public class Secondary
{
    public string __typename { get; set; }
    public string primary { get; set; }
    public bool disabled { get; set; }
    public Action action { get; set; }
}

public class Secondary2
{
    public string __typename { get; set; }
    public string text { get; set; }
    public string theme_temp { get; set; }
    public IconTemp icon_temp { get; set; }
    public object mark { get; set; }
}

public class SelectAnalytics
{
    public string __typename { get; set; }
    public string linkName { get; set; }
    public string referrerId { get; set; }
}

public class Selected
{
    public string __typename { get; set; }
    public string id { get; set; }
    public int min { get; set; }
    public int max { get; set; }
}

public class ShoppingContext
{
    public string __typename { get; set; }
    public object multiItem { get; set; }
}

public class SortSection
{
    public string __typename { get; set; }
    public object title { get; set; }
    public List<Field> fields { get; set; }
}

public class SponsoredListing
{
    public string __typename { get; set; }
    public string clickTrackingUrl { get; set; }
    public string impressionTrackingUrl { get; set; }
    public string hotelImage { get; set; }
    public TrackingInfo trackingInfo { get; set; }
}

public class StrikeOut
{
    public string __typename { get; set; }
    public double amount { get; set; }
    public string formatted { get; set; }
    public CurrencyInfo currencyInfo { get; set; }
}

public class Summary
{
    public string __typename { get; set; }
    public int matchedPropertiesSize { get; set; }
    public PricingScheme pricingScheme { get; set; }
    public object regionCompression { get; set; }
    public LoyaltyInfo loyaltyInfo { get; set; }
    public ResultsTitleModel resultsTitleModel { get; set; }
    public List<ResultsSummary> resultsSummary { get; set; }
}

public class TileMultiSelectionOption
{
    public string __typename { get; set; }
    public string id { get; set; }
    public string primary { get; set; }
    public object secondary { get; set; }
    public Icon icon { get; set; }
    public Analytics analytics { get; set; }
    public string value { get; set; }
    public object description { get; set; }
    public bool selected { get; set; }
    public bool disabled { get; set; }
    public bool @default { get; set; }
    public SelectAnalytics selectAnalytics { get; set; }
    public DeselectAnalytics deselectAnalytics { get; set; }
}

public class Toolbar
{
    public string __typename { get; set; }
    public string primary { get; set; }
    public Actions actions { get; set; }
}

public class TrackingInfo
{
    public string __typename { get; set; }
    public string beaconIssued { get; set; }
    public string candidateHmGuid { get; set; }
    public string position { get; set; }
    public string rank { get; set; }
    public string slots { get; set; }
    public string testVersionOverride { get; set; }
    public string trackingData { get; set; }
}

public class TypeaheadInfo
{
    public string __typename { get; set; }
    public string client { get; set; }
    public bool isDestination { get; set; }
    public string lineOfBusiness { get; set; }
    public int maxNumberOfResults { get; set; }
    public object packageType { get; set; }
    public bool personalize { get; set; }
    public int regionType { get; set; }
    public string typeaheadFeatures { get; set; }
}

public class UniversalSortAndFilter
{
    public string __typename { get; set; }
    public Toolbar toolbar { get; set; }
    public RevealAction revealAction { get; set; }
    public ApplyAction applyAction { get; set; }
    public List<FilterSection> filterSections { get; set; }
    public List<SortSection> sortSections { get; set; }
}

public class Uri
{
    public string __typename { get; set; }
    public string value { get; set; }
}

