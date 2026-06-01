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
                PrintError("Guest already Eists"); return;
            }
            guests.Add(new Guest(name, id));
            PrintSuccess("Guest added successfully!");
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
                PrintError("Room already exists"); return;
            }

            rooms.Add(new Room(number, type));
            Console.WriteLine($"Rooms Count = {rooms.Count}");

            PrintSuccess("Room added successfully");
        }

        // BookRoom
        public void BookRoom(string nationalID, int roomNumber)
        {
            Guest guest = FindGuest(nationalID);

            if (guest == null)
            {
                PrintError("Guest not found");
                return;
            }

            Room room = rooms.Find(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                PrintError("Room not found");
                return;
            }

            if (room.IsBooked)
            {
                PrintError("Room already booked");
                return;
            }

            room.Book();

            Booking booking = new Booking(guest, room);

            bookings.Add(booking);

            PrintSuccess($"Booking Successful | ID: {booking.BookingID}");
        }

        //CancelBooking
        public void CancelBooking(int bookingID)
        {
            Booking booking=bookings.Find(b=> b.BookingID == bookingID);
            if(booking == null)
            {
                PrintError("Booking not found"); return;

            }

            booking.Room.CancelBooking();

            bookings.RemoveAll(b=> b.BookingID == bookingID);
            PrintSuccess("Booking cancelled.");

        }

        //Available Rooms
        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Rooms Count = {rooms.Count}");
            PrintHeader("Available Rooms");

            Console.WriteLine("+-----------+-----------+------------+");
            Console.WriteLine("| Room No   | Type      | Available  |");
            Console.WriteLine("+-----------+-----------+------------+");

            foreach (Room room in rooms)
            {
                if (!room.IsBooked)
                {
                    Console.WriteLine(
                        $"| {room.RoomNumber,-9} | {room.RoomType,-9} | Yes        |");
                }
            }

            Console.WriteLine("+-----------+-----------+------------+");
        }

        //Booked Rooms
        public void DisplayBookedRooms()
        {
            PrintHeader("Booked Rooms");

            Console.WriteLine("+-----------+---------------+-----------+-----------+");
            Console.WriteLine("| BookingID | Guest         | Room No   | Type      |");
            Console.WriteLine("+-----------+---------------+-----------+-----------+");

            foreach (Booking booking in bookings)
            {
                Console.WriteLine(
                    $"| {booking.BookingID,-9} | {booking.Guest.FullName,-13} | {booking.Room.RoomNumber,-9} | {booking.Room.RoomType,-9} |");
            }

            Console.WriteLine("+-----------+---------------+-----------+-----------+");
        }

        //SearchGuestBookings

        public void SearchGuestBookings(string nationalID)
        {
            Guest guest = FindGuest(nationalID);

            if (guest == null) {
                PrintError("Guest not found");return;
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

            PrintHeader("Hotel Statistics");

            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine($"| Registered Guests     : {guests.Count,-12}|");
            Console.WriteLine($"| Total Rooms           : {rooms.Count,-12}|");
            Console.WriteLine($"| Booked Rooms          : {bookedRooms,-12}|");
            Console.WriteLine($"| Available Rooms       : {availableRooms,-12}|");
            Console.WriteLine($"| Guests Ever Created   : {Guest.GetTotalGuestsCreated(),-12}|");
            Console.WriteLine("+--------------------------------------+");
        }


        private void PrintSuccess(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private void PrintHeader(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + msg);
            Console.ResetColor();
        }


    }
}
