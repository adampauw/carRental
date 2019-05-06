using ConsoleApp.PostgreSQL;
using Microsoft.EntityFrameworkCore;

public class CarRentalDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=adampauw;Username=postgres;");
    }