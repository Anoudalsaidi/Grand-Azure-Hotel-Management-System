using GrandAzureHotel.Models;

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
                Console.WriteLine("\n***** Grand Azure Hotel *****");
                Console.WriteLine("1. Add Guest");
                Console.WriteLine("2. Add Room");
                Console.WriteLine("3. Book Room");
                Console.WriteLine("4. Cancel Booking");
                Console.WriteLine("5. Available Rooms");
                Console.WriteLine("6. Booked Rooms");
                Console.WriteLine("7. Search Guest");
                Console.WriteLine("8. Statistics");
                Console.WriteLine("0. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice) { }

            }
            while (choice != 0);

        }

    }
}
