namespace HotelWebApp.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool Available { get; set; }
        public double RegionId { get; set; }
    }
}