using System.Collections.Generic;

namespace HomeWorkDotNetBasic1.Entities
{
    public class Race
    {
        public int RaceId { get; set; }
        public string RaceName { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<RaceResult> Results { get; set; }
    }
}
