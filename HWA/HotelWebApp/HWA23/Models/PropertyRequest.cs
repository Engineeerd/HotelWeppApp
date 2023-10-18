using System.Collections.Generic;

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
        public Destination destination { get; set; }
        public CheckInDate checkInDate { get; set; }
        public CheckOutDate checkOutDate { get; set; }
        public List<Room> rooms { get; set; }
    }
}