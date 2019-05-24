using ConsoleApp.PostgreSQL;
using Microsoft.EntityFrameworkCore;

public class CarRentalDBContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Rental> Rentals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=adampauw;Username=postgres;");
}