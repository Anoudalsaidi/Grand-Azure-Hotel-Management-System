using System;
using System.Collections.Generic;
using System.Text;

namespace GrandAzureHotel.Models
{
    public class Booking
    {
        //fields
        private static int nextBookingID = 1001;
        private int bookingID;
        private Guest guest;
        private Room room;


        //properties
        public int BookingID { get { return bookingID; } }
        public Guest Guest { get { return guest; } }
        public Room Room { get { return room; } }

        //Constructor
        public Booking(Guest guest, Room room)
        {
            bookingID = nextBookingID++;
            this.guest = guest;
            this.room = room;
        }

        //DisplayInfo Method
        public void DisplayInfo()
        {
            Console.WriteLine($"BookingID : {BookingID}");
            Console.WriteLine($"Guest : {Guest.FullName}");
            Console.WriteLine($"Room : {Room.RoomNumber}");
            Console.WriteLine($"Type : {Room.RoomType}");

        }
    }
}
