using System.Collections.Generic;

namespace HotelWebApp.Models
{
    public class PropertySearch
    {
        public string __typename { get; set; }
        public List<Property> properties { get; set; }
    }
}