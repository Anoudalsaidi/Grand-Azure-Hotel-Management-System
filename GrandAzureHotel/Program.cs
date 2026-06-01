using GrandAzureHotel.Models;
using System.Threading.Channels;
using System.Xml.Linq;

namespace GrandAzureHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Test Guest Class
            //Guest g1 = new Guest("Anoud", "999");
            //Guest g2 = new Guest("Ahmed", "222");
            //Console.WriteLine(Guest.GetTotalGuestsCreated());

            ////Test Room Class
            //Room room = new Room(101, "Suite");
            //room.DisplayInfo();
            //room.Book();
            //room.DisplayInfo();



            Hotel hotel = new Hotel("Grand Azure");

            int choice;

            do
            {
                Console.WriteLine("\n***** Grand Azure Hotel *****\n");
                Console.WriteLine("1. Add Guest");
                Console.WriteLine("2. Add Room");
                Console.WriteLine("3. Book Room");
                Console.WriteLine("4. Cancel Booking");
                Console.WriteLine("5. Available Rooms");
                Console.WriteLine("6. Booked Rooms");
                Console.WriteLine("7. Search Guest");
                Console.WriteLine("8. Statistics");
                Console.WriteLine("0. Exit");

                Console.WriteLine("\nEnter Choise : ");

                choice = int.Parse(Console.ReadLine());

                switch (choice) {

                    case 1:
                        Console.WriteLine("Enter Guest Name:");
                        string gName = Console.ReadLine();

                        Console.Write("Enter National ID: ");
                        string gId = Console.ReadLine();

                        hotel.AddGuest(gName, gId);
                        break;

                    case 2:
                        Console.Write("Enter Room Number: ");
                        int roomNumber = int.Parse(Console.ReadLine());

                        Console.Write("Enter Room Type (Standard / Deluxe / Suite): ");
                        string roomType = Console.ReadLine();

                        hotel.AddRoom(roomNumber, roomType);
                        break;

                    case 3:
                        Console.Write("Enter Guest National ID: ");
                        string guestId = Console.ReadLine();

                        Console.Write("Enter Room Number: ");
                        int bookRoom = int.Parse(Console.ReadLine());

                        hotel.BookRoom(guestId, bookRoom);
                        break;


                    case 4:
                        Console.Write("Enter Booking ID: ");
                        int bookingId = int.Parse(Console.ReadLine());

                        hotel.CancelBooking(bookingId);
                        break;



                    case 5:
                        hotel.DisplayAvailableRooms();
                        break;


                    case 6:
                        hotel.DisplayBookedRooms();
                        break;


                    case 7:
                        Console.Write("Enter National ID: ");
                        string searchId = Console.ReadLine();

                        hotel.SearchGuestBookings(searchId);
                        break;


                    case 8:
                        hotel.DisplayStatistics();
                        break;


                    case 0:
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }
            while (choice != 0);

        }

    }
}
