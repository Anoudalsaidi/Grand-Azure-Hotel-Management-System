using System;
using System.Collections.Generic;
using System.Text;

namespace GrandAzureHotel.Models
{
    public class Hotel
    {
        //fields
        private List<Guest> guests;
        private List<Room> rooms;
        private List<Booking> bookings;

        //Auto Property for hotel name
        public string HotelName { get; }

        //Constructor
        public Hotel(string name)
        {
            HotelName=name;
            guests = new List<Guest>();
            rooms = new List<Room>();
            bookings = new List<Booking>();
        }
    }
}
