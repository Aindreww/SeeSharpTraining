using System;

namespace HomeWorkSessionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WirelessMouse wirelessMouse = new WirelessMouse
            {
                Manufacturer = "Logitech",
                MouseType = "Optical",
                BatteryLifeRemaining = 49.5,
                SensorType = "Laser",
                DpiRange = "800-16000",
                ManufactureDate = DateTime.Now.AddDays(-365),
                ProgrammableButtons = 6
            };

            WiredMouse wiredMouse = new WiredMouse
            {
                Manufacturer = "Microsoft",
                SensorType = "Optical",
                DpiRange = "400-4000",
                ManufactureDate = DateTime.Now.AddDays(-15),
                ProgrammableButtons = 4
            };

            Console.WriteLine("Wireless Mouse Details:");
            wirelessMouse.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Wired Mouse Details:");
            wiredMouse.DisplayDetails();
        }


    
    }
}