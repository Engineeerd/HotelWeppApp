using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelWebApp.Models
{
    public class HotelRequest
    {
        [Required(ErrorMessage = "Location is required!")]
        public string Location { get; set; }
        [Required(ErrorMessage = "A check in date is required!")]
        public string CheckIn { get; set; }
        [Required(ErrorMessage = "A check out date is required!")]
        public string CheckOut { get; set; }
        public int resultsSize { get; set; }
        public List<Room> rooms { get; set; }
        public Destination destination { get; set; }
        public CheckInDate checkInDate { get; set; }
        public CheckOutDate checkOutDate { get; set; }
        public int resultsStartingIndex { get; set; }
    }
}