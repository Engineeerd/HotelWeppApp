using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebApp.Models
{
    public class PropertyImage
    {
        public string __typename { get; set; }
        public string alt { get; set; }
        public FallbackImage fallbackImage { get; set; }
        public Image image { get; set; }
        public int subjectId { get; set; }
    }
}