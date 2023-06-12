namespace HomeWorkDotNetBasic1.Entities
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
