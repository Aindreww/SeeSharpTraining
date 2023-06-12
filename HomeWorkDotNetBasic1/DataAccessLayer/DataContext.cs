using HomeWorkDotNetBasic1.Entities;
using Microsoft.EntityFrameworkCore;


namespace HomeWorkDotNetBasic1.DataAccessLayer
{
    public class DataContext
    {
        public class AppDbContext : DbContext
        {
            public DbSet<Team> Teams { get; set; }
            public DbSet<Driver> Drivers { get; set; }
            public DbSet<Race> Races { get; set; }
            public DbSet<RaceResult> RaceResults { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-ABLED5F\\SQLEXPRESS; Database = FormulaOneManager; Trusted_Connection = True");
            }
        }
    }
}
