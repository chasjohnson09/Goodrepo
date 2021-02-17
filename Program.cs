using System;

namespace Cellphone
{
    class Program
    {
        static void Main(string[] args)
        {
            var cp1 = new Cellphone
            {
                Phonenumber = "513-555-1212",
                Serviceprovider = "Verizon",
                OperatingSystem = "iOS",
                Capacity = 128,
                Model = "iPhone X"
            };
            var cp2 = new Cellphone
            {
                Phonenumber = "513-553-1212",
                Serviceprovider = "Sprint",
                OperatingSystem = "Android",
                Capacity = 128,
                Model = "Pixel 4"
            };

            var cellphones = new Cellphone[] { cp1, cp2 };

            foreach(var cp in cellphones)
            {
                
                Console.WriteLine($" phone number is {cp1.Phonenumber}");
            }
        }
    }
}
