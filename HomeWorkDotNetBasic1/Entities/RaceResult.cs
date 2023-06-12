namespace HomeWorkDotNetBasic1.Entities
{
    public class RaceResult
    {
        public int RaceResultId { get; set; }
        public int Position { get; set; }
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
