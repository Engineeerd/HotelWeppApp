namespace HWA23.Models
{
    public class Region
    {
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