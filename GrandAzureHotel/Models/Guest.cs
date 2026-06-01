using System;
using System.Collections.Generic;
using System.Text;

namespace GrandAzureHotel.Models
{
    public class Guest
    {
        //Fields
        private static int totalGuestsCreated;
        private string nationalID;
        private string fullName;

        //properties
        public string NationalID
        {
            get { return nationalID; }
        }

        public string FullName
        {
            get { return fullName; }
            set { if (!string.IsNullOrWhiteSpace(value))
                { fullName = value; }
            }
        }

        //Constructor
        public Guest(string name, string id)
        {
            fullName = name;
            nationalID = id;

            totalGuestsCreated++;
        }
    


    

        //static method
    public static int GetTotalGuestsCreated()
        {
            return totalGuestsCreated;
        }

        // method for display Info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {fullName}");
            Console.WriteLine($"National ID :{nationalID}");
        }
    }
}
