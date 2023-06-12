using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkDotNetBasic1.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}

