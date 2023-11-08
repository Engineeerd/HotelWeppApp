using System.Collections.Generic;

namespace HotelWebApp.Models
{
    public class Room
    {
        public int adults { get; set; }
        public List<Child> children { get; set; }
    }
}