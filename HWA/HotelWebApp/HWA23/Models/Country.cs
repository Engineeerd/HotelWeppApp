
using Newtonsoft.Json;

using System.Collections.Generic;

public class AE
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class AppLanguage
{
    public string Ios { get; set; }
}

public class AppSupportURLs
{
    public string Ios { get; set; }
    public string Android { get; set; }
}

public class AR
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class AS
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class AT
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public string TimeFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShowAirlinePaymentMethodFeeLegalMessage { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class AU
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldDisplayCirclesForRatings { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class BE
{
    public int SiteId { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public string TimeFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool ShowAirlinePaymentMethodFeeLegalMessage { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class BR
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool ShouldUseWebViewSyncCookieStore { get; set; }
    public bool AbTestHotelsWebCheckout { get; set; }

    [JsonProperty("webCheckoutURL:hotels")]
    public string WebCheckoutURLHotels { get; set; }

    [JsonProperty("webBookingConfirmationURL:hotels")]
    public string WebBookingConfirmationURLHotels { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class CA
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public CruiseSupportedLocales CruiseSupportedLocales { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public string TimeFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class CH
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool ShowVATInsteadOfTaxesAndFee { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public string TimeFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public bool AdjustPricingMessagingForAirlinePaymentMethodFee { get; set; }
    public string AirlinePaymentMethodFeeMessageType { get; set; }
    public string MarketingOptIn { get; set; }

    [JsonProperty("requiredPaymentFields:flights")]
    public string RequiredPaymentFieldsFlights { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool ShowAirlinePaymentMethodFeeLegalMessage { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class CL
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class CN
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldDisplayCirclesForRatings { get; set; }
    public bool ShouldUseWebViewSyncCookieStore { get; set; }
    public bool AbTestHotelsWebCheckout { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class CO
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class CruiseSupportedLocales
{
    public bool EnCA { get; set; }
    public bool FrCA { get; set; }
}

public class DE
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool CarsEnabled { get; set; }

    [JsonProperty("earn2xRewardsPoints:hotels")]
    public bool Earn2xRewardsPointsHotels { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public bool RailsWebViewEnabled { get; set; }

    [JsonProperty("android.webViewEnabledForRails")]
    public bool AndroidWebViewEnabledForRails { get; set; }

    [JsonProperty("android.webViewABTestIDForRails")]
    public string AndroidWebViewABTestIDForRails { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool IsDoubleEarnMessageDisabled { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class DK
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class ES
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class FI
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public string MarketingOptIn { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class FR
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool FeaturedAmenitiesEnabled { get; set; }
    public bool ShouldShowRecommendedSortMessage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class GB
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool PackagesATOLMessageEnabled { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public bool RailsEnabled { get; set; }

    [JsonProperty("android.webViewEnabledForRails")]
    public bool AndroidWebViewEnabledForRails { get; set; }

    [JsonProperty("android.webViewABTestIDForRails")]
    public string AndroidWebViewABTestIDForRails { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShowPackageFreeUnrealDeal { get; set; }
    public bool ShowResortFeesInHotelLocalCurrency { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class GR
{
    public int SiteId { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class HK
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowLastNameFirst { get; set; }
    public bool ShouldShowExampleNames { get; set; }
    public bool ShouldHideMiddleName { get; set; }

    [JsonProperty("requiredPaymentFields:flights")]
    public string RequiredPaymentFieldsFlights { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public bool HideBillingAddressFields { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class HU
{
    public int SiteId { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class ID
{
    public int SiteId { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldHideMiddleName { get; set; }
    public bool ShouldDisplayFlightDropDownList { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class IE
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class IN
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }

    [JsonProperty("android.browserViewEnabledForFlights")]
    public bool AndroidBrowserViewEnabledForFlights { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowWebCheckout { get; set; }
    public bool ShouldUseWebViewSyncCookieStore { get; set; }

    [JsonProperty("webCheckoutURL:hotels")]
    public string WebCheckoutURLHotels { get; set; }

    [JsonProperty("webBookingConfirmationURL:hotels")]
    public string WebBookingConfirmationURLHotels { get; set; }

    [JsonProperty("webBookingConfirmationURL:flights")]
    public string WebBookingConfirmationURLFlights { get; set; }

    [JsonProperty("webCheckoutURL:flights")]
    public string WebCheckoutURLFlights { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class IS
{
    public int SiteId { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class IT
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool PackagesHSRIncludesHeaderEnabled { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public bool ShowETPPreauthorizationsMessage { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class JP
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool PackagesHSRIncludesHeaderEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowLastNameFirst { get; set; }
    public bool ShouldShowExampleNames { get; set; }
    public bool ShouldHideMiddleName { get; set; }
    public bool ShouldShowRewards { get; set; }

    [JsonProperty("requiredPaymentFields:flights")]
    public string RequiredPaymentFieldsFlights { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public bool HideBillingAddressFields { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class KR
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class LATAM
{
    public int SiteId { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class MX
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class MY
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowLastNameFirst { get; set; }
    public bool ShouldHideMiddleName { get; set; }
    public bool ShouldUseWebViewSyncCookieStore { get; set; }
    public bool AbTestHotelsWebCheckout { get; set; }

    [JsonProperty("webCheckoutURL:hotels")]
    public string WebCheckoutURLHotels { get; set; }

    [JsonProperty("webBookingConfirmationURL:hotels")]
    public string WebBookingConfirmationURLHotels { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string BusinessRegion { get; set; }
    public bool ShowAirlinePaymentMethodFeeLegalMessage { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class NL
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class NO
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public string TimeFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShowAirlinePaymentMethodFeeLegalMessage { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class NZ
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldDisplayCirclesForRatings { get; set; }
    public bool ShowAirlinePaymentMethodFeeLegalMessage { get; set; }
    public string BusinessRegion { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public int TripOverviewHotelXSellAmount { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class PE
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string CarsWebViewPageUrl { get; set; }
    public bool ShouldUseCarsWebviewTestToShowCars { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class PH
{
    public int SiteId { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowLastNameFirst { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class PT
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class Countries
{
    public AE AE { get; set; }
    public AR AR { get; set; }
    public AS AS { get; set; }
    public AT AT { get; set; }
    public AU AU { get; set; }
    public BE BE { get; set; }
    public BR BR { get; set; }
    public CA CA { get; set; }
    public CH CH { get; set; }
    public CL CL { get; set; }
    public CN CN { get; set; }
    public CO CO { get; set; }
    public DE DE { get; set; }
    public DK DK { get; set; }
    public ES ES { get; set; }
    public FI FI { get; set; }
    public FR FR { get; set; }
    public GB GB { get; set; }
    public GR GR { get; set; }
    public HK HK { get; set; }
    public HU HU { get; set; }
    public ID ID { get; set; }
    public IE IE { get; set; }
    public IN IN { get; set; }
    public IS IS { get; set; }
    public IT IT { get; set; }
    public JP JP { get; set; }
    public KR KR { get; set; }
    public LATAM LATAM { get; set; }
    public MX MX { get; set; }
    public MY MY { get; set; }
    public NL NL { get; set; }
    public NO NO { get; set; }
    public NZ NZ { get; set; }
    public PE PE { get; set; }
    public PH PH { get; set; }
    public PT PT { get; set; }
    public SE SE { get; set; }
    public SG SG { get; set; }
    public TH TH { get; set; }
    public TR TR { get; set; }
    public TW TW { get; set; }
    public US US { get; set; }
    public VN VN { get; set; }
    public XE XE { get; set; }
    public ZA ZA { get; set; }
}

public class SE
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class SG
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool ShouldShowLastNameFirst { get; set; }
    public bool ShouldShowRewards { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool HideBillingAddressFields { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public bool ShowDatelessHotelExcludesTaxesAndFees { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class SupportedLocale
{
    public AppLanguage AppLanguage { get; set; }
    public string LocaleIdentifier { get; set; }
    public int LanguageIdentifier { get; set; }
    public string LocaleBasedPointOfSaleName { get; set; }
    public string AppInfoURL { get; set; }
    public string CreateAccountMarketingText { get; set; }
    public string ForgotPasswordURL { get; set; }
    public AppSupportURLs AppSupportURLs { get; set; }
    public string BookingSupportURL { get; set; }
    public string WebsiteURL { get; set; }
    public string AccountURL { get; set; }
    public string ResultsSortFAQLegalLink { get; set; }
    public string TermsAndConditionsURL { get; set; }
    public string TermsOfBookingURL { get; set; }
    public string LearnAboutSortAndFilterURL { get; set; }
    public string PrivacyPolicyURL { get; set; }
    public string LoyaltyTermsAndConditionsURL { get; set; }
    public string CoronavirusInfoUrl { get; set; }
    public string LanguageCode { get; set; }
    public string AirlineRulesURL { get; set; }
    public string CarsTabWebViewURL { get; set; }
    public string RailsRulesAndRestrictionsURL { get; set; }
    public string RailsNationalRailConditionsOfTravelURL { get; set; }
    public string RailsSupplierTermsAndConditionsURL { get; set; }
    public string RailsTermOfUseURL { get; set; }
    public string RailsPrivacyPolicyURL { get; set; }
    public string RailsPaymentAndTicketDeliveryFeesURL { get; set; }
    public string RailsNationalRailConditionsOfTravelLinkText { get; set; }
    public string RailsSupplierTermsAndConditionsLinkText { get; set; }
    public string RailsTermOfUseLinkText { get; set; }
    public string RailsPaymentAndTicketDeliveryFeesLinkText { get; set; }
    public string RailsRulesAndRestrictionsLinkText { get; set; }
    public string RailsPrivacyPolicyLinkText { get; set; }
    public string ContactUsSupportArticleURL { get; set; }
    public string TermsOfBookingLinkText { get; set; }
    public string EvolableAsiaUrl { get; set; }
    public string GoToTravelInfoURL { get; set; }
    public string LocaleSpecificSupportPhoneNumber { get; set; }
    public string DoNotSellMyPersonalInformationURL { get; set; }
    public string CreditCardUrl { get; set; }
    public string InsuranceURL { get; set; }
}

public class SupportPhoneNumber
{
    [JsonProperty("*")]
    public string Num { get; set; }
}

public class TH
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class TR
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class TW
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string MemberDealCardImageUrl { get; set; }
    public string LastMinuteDealsCardImageUrl { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class US
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool PackagesEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool DoNotSellMyPersonalInformationEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShowPackageFreeUnrealDeal { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class VN
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool LxEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public bool PackagesEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public string TripOverviewHotelXSellCurrencyCode { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string MarketingOptIn { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class XE
{
    public int SiteId { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

public class ZA
{
    public int SiteId { get; set; }
    public SupportPhoneNumber SupportPhoneNumber { get; set; }
    public bool RemoveAvailabilityMessageEnabled { get; set; }
    public bool ShowStrikeThroughPriceDetails { get; set; }
    public int TPID { get; set; }
    public int EAPID { get; set; }
    public bool GdprEnabled { get; set; }
    public bool FlightsEnabled { get; set; }
    public bool CarsEnabled { get; set; }
    public bool LxEnabled { get; set; }

    [JsonProperty("swpEnabled:hotels")]
    public bool SwpEnabledHotels { get; set; }

    [JsonProperty("earnMessageEnabled:hotels")]
    public bool EarnMessageEnabledHotels { get; set; }
    public bool CarsWebViewEnabled { get; set; }
    public string Url { get; set; }
    public string CountryCode { get; set; }
    public List<SupportedLocale> SupportedLocales { get; set; }
    public List<string> AutomaticallyMappedLocales { get; set; }
    public string Branding { get; set; }
    public string DeepLinkDateFormat { get; set; }
    public int PointOfSaleId { get; set; }
    public bool ShouldDisplayAveragePrices { get; set; }
    public bool SupportsVipAccess { get; set; }
    public string MarketingOptIn { get; set; }
    public bool ShouldShowRewards { get; set; }
    public string HotMIPSavingsPercentage { get; set; }
    public string VrboTermsAndConditionsURL { get; set; }
    public string CookiePolicyURLString { get; set; }
    public bool EnrollInLoyalty { get; set; }
}

