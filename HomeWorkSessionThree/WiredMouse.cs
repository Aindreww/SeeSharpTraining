namespace HomeWorkSessionThree
{
    public class WiredMouse: Mouse
    {
        public string SensorType { get; set; }
        public string DpiRange { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int ProgrammableButtons { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Sensor Type: " + SensorType);
            Console.WriteLine("DPI Range: " + DpiRange);
            Console.WriteLine("Manufacture Date: " + ManufactureDate);
            Console.WriteLine("Programmable Buttons: " + ProgrammableButtons);
        }
    }
}
