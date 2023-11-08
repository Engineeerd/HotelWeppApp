namespace HotelWebApp.Models
{
    public class Availability
    {
        public string __typename { get; set; }
        public bool available { get; set; }
        public int? minRoomsLeft { get; set; }
    }
}
