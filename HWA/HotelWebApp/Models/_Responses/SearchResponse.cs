using Newtonsoft.Json;

using System.Collections.Generic;

namespace HotelWebApp.Models.Responses
{
    public class SearchResponse
    {
        [JsonProperty("sr")]
        public List<HotelResponse> Hotels { get; set; }
    }
}