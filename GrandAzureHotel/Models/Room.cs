using System;
using System.Collections.Generic;
using System.Text;

namespace GrandAzureHotel.Models
{
    public class Room
    {
        //fields
        private int roomNumber;
        private string roomType;
        private bool isBooked;

        //Properties
        public int RoomNumber { get { return roomNumber; } }
        public string RoomType { get { return roomType; } }
        public bool IsBooked { get { return isBooked; } }

        //Constructor
        public Room(int roomNum, string roomtype)
        {
            roomNum = roomNumber;
            roomtype = roomType;
            isBooked = false;
        }

        // method for Book
        public bool Book()
        {
            if (isBooked)
                return false;
            isBooked = true;
            return true;
        }

        // method for CancelBooking
        public void CancelBooking()
        {
            isBooked = false;
        }

        // method for DisplayInfo
        public void DisplayInfo()
        {
            Console.WriteLine($"Room: {roomNumber} | Type : {roomType} | Available : {isBooked}");
        }

    }
}
