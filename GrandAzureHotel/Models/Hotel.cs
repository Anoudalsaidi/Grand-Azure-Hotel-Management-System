using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

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
            HotelName = name;
            guests = new List<Guest>();
            rooms = new List<Room>();
            bookings = new List<Booking>();
        }

        // AddGuest
        public void AddGuest(string name, string id)
        {
            Guest existingGuest = guests.Find(g => g.NationalID == id);
            if (existingGuest != null)
            {
                Console.WriteLine("Guest already Eists"); return;
            }
            guests.Add(new Guest(name, id));
            Console.WriteLine("Guest added successfully!");
        }

        //FindGuest

        public Guest FindGuest(string nationalID)
        {
            return guests.Find(g => g.NationalID == nationalID);
        }

        //AddRoom
        public void AddRoom(int number, string type)
        {
            Room room = rooms.Find(r => r.RoomNumber == number);
            if (room != null)
            {
                Console.WriteLine("Room already exists"); return;
            }

            rooms.Add(new Room(number, type));

            Console.WriteLine("Room added successfully");
        }

        // BookRoom
        public void BookRoom(string nationslID, int roomNumber)
        {
            Guest guest = FindGuest(nationslID);
            if (guest != null)
            {
                Console.WriteLine("Guest not found"); return;

            }

            Room room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null)
            {
                Console.WriteLine("Room not found"); return;
            }
            if (room.IsBooked)
            {
                Console.WriteLine("Room already booked"); return;
            }

            room.Book();

            Booking booking = new Booking(guest, room);
            bookings.Add(booking);
            Console.WriteLine($"Booking Successful | ID: {booking.BookingID}");
        }

        //CancelBooking
        public void CancelBooking(int bookingID)
        {
            Booking booking=bookings.Find(b=> b.BookingID == bookingID);
            if(booking == null)
            {
                Console.WriteLine("Booking not found"); return;

            }

            booking.Room.CancelBooking();

            bookings.RemoveAll(b=> b.BookingID == bookingID);
            Console.WriteLine("Booking cancelled.");

        }

        //Available Rooms
        public void DisplayAvailableRooms()
        {
            foreach (Room room in rooms) {
                if (!room.IsBooked) { room.DisplayInfo(); }
            }
                
        }

        //Booked Rooms
        public void DisplayBookedRooms()
        {
            foreach (Booking booking in bookings)
            {
                booking.DisplayInfo();
            }
        }

        //SearchGuestBookings

        public void SearchGuestBookings(string nationalID)
        {
            Guest guest = FindGuest(nationalID);

            if (guest == null) {
                Console.WriteLine("Guest not found");return;
            }

            guest.DisplayInfo();

            foreach (Booking booking in bookings) {
                if (booking.Guest.NationalID == nationalID) {
                    booking.DisplayInfo();
                }
            }
        }

        //Statistics
        public void DisplayStatistics()
        {
            int bookedRooms = rooms.Count(r => r.IsBooked);

            int availableRooms = rooms.Count(r => !r.IsBooked);

            Console.WriteLine($"Guests : {guests.Count}");
            Console.WriteLine($"Rooms : {rooms.Count}");
            Console.WriteLine($"Booked Rooms: {bookedRooms}");
            Console.WriteLine($"Available Rooms: {availableRooms}");

            Console.WriteLine($"Total Guests Ever Created: {Guest.GetTotalGuestsCreated()}");



        }


    }
}
