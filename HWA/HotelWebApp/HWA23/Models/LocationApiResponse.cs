using System.Collections.Generic;

namespace HWA23.Models
{
    //public class LocationApiResponse
    //{
    //    public List<Location> Suggestions { get; set; }
    //}

    public class Entity
    {
        public string geoId { get; set; }
        public string destinationId { get; set; }
        public string landmarkCityDestinationId { get; set; }
        public string type { get; set; }
        public string redirectPage { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public object searchDetail { get; set; }
        public string caption { get; set; }
        public string name { get; set; }
    }

    public class Root
    {
        public string term { get; set; }
        public int moresuggestions { get; set; }
        public object autoSuggestInstance { get; set; }
        public string trackingID { get; set; }
        public bool misspellingfallback { get; set; }
        public List<Suggestion> suggestions { get; set; }
        public bool geocodeFallback { get; set; }
    }

    public class Suggestion
    {
        public string group { get; set; }
        public List<Entity> entities { get; set; }
    }

}
