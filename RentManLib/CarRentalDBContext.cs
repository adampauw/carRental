using Microsoft.EntityFrameworkCore;

namespace RentmanLib
{

  public class CarRentalDBContext : DbContext
  {
    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Rental> Rentals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Database=adampauw;Username=postgres;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Rental>()
               .HasIndex(rental => new { rental.ReturnDate, rental.CarId }).IsUnique(true);
    }
  }
}