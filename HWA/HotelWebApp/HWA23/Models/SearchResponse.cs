using Newtonsoft.Json;
using System.Collections.Generic;

namespace HWA.Models
{
    public class Coordinates
    {
        public string lat { get; set; }
        public string @long { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public string isoCode2 { get; set; }
        public string isoCode3 { get; set; }
    }

    public class EssId
    {
        public string sourceName { get; set; }
        public string sourceId { get; set; }
    }

    public class HierarchyInfo
    {
        public Country country { get; set; }
    }

    public class HotelAddress
    {
        public string street { get; set; }
        public string city { get; set; }
        public string province { get; set; }
    }

    public class RegionNames
    {
        public string fullName { get; set; }
        public string shortName { get; set; }
        public string displayName { get; set; }
        public string primaryDisplayName { get; set; }
        public string secondaryDisplayName { get; set; }
        public string lastSearchName { get; set; }
    }

    public class SearchResponse
    {
        public List<Sr> sr { get; set; }
    }

    public class Sr
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public string index { get; set; }
        public string gaiaId { get; set; }
        public RegionNames regionNames { get; set; }
        public EssId essId { get; set; }
        public Coordinates coordinates { get; set; }
        public HierarchyInfo hierarchyInfo { get; set; }
        public string isMinorAirport { get; set; }
        public string hotelId { get; set; }
        public string cityId { get; set; }
        public HotelAddress hotelAddress { get; set; }
        public string subtype { get; set; }
    }
}