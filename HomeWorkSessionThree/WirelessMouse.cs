namespace HomeWorkSessionThree
{
    public class WirelessMouse: Mouse
    {
        public string MouseType { get; set; }
        public double BatteryLifeRemaining { get; set; }
        public string SensorType { get; set; }
        public string DpiRange { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int ProgrammableButtons { get; set; }

        public void DisplayBatteryLife()
        {
            Console.WriteLine("Battery Life Remaining: " + BatteryLifeRemaining + "%");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Mouse Type: " + MouseType);
            Console.WriteLine("Sensor Type: " + SensorType);
            Console.WriteLine("DPI Range: " + DpiRange);
            Console.WriteLine("Manufacture Date: " + ManufactureDate);
            Console.WriteLine("Programmable Buttons: " + ProgrammableButtons);
            DisplayBatteryLife();
        }
    }
}
