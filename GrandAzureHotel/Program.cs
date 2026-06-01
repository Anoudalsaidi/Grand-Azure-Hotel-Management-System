using GrandAzureHotel.Models;

namespace GrandAzureHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Guest Class
            Guest g1 = new Guest("Anoud", "999");
            Guest g2 = new Guest("Ahmed", "222");
            Console.WriteLine(Guest.GetTotalGuestsCreated());
        }
    }
}
