using Newtonsoft.Json;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HWA23.Models
{
    public class CheckInDate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }

    public class CheckOutDate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }

    public class Destination
    {
        public string regionId { get; set; }
    }

    public class Room
    {
        public int adults { get; set; }
        public List<Child> children { get; set; }
    }

    public class Child
    {
        public int age { get; set; }
    }

    public class HotelRequestData
    {
        [Required(ErrorMessage = "Location is required!")]
        public string Location { get; set; }
        [Required(ErrorMessage = "A check in date is required!")]
        public string CheckIn { get; set; }
        [Required(ErrorMessage = "A check out date is required!")]
        public string CheckOut { get; set; }

        public Destination destination { get; set; }
        public CheckInDate checkInDate { get; set; }
        public CheckOutDate checkOutDate { get; set; }
        public List<Room> rooms { get; set; }
        public int resultsStartingIndex { get; set; }
        public int resultsSize { get; set; }
        
    }
}