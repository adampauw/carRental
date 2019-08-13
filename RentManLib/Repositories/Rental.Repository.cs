using System;
using System.Linq;

namespace RentmanLib
{
  public class RentalRepository
  {
    public void Add()
    {
      using (var db = new CarRentalDBContext())
      {
        db.Customers
        .ToList()
        .ForEach(Customer => Console.WriteLine("Id:" + Customer.Id + "  " + Customer.first_name + " " + Customer.last_name));
        Console.WriteLine("");
        Console.WriteLine("Enter Id of the Customer");
        int customerId = Convert.ToInt32(Console.ReadLine());
        var foundCustomer = db.Customers.Find(customerId);

        db.Cars
        .ToList()
        .ForEach(Car => Console.WriteLine("Id:" + Car.Id + "  " + Car.Make + " " + Car.Model));
        Console.WriteLine("");
        Console.WriteLine("Enter Id of the Car they wish to Rent");
        int carId = Convert.ToInt32(Console.ReadLine());
        var foundCar = db.Cars.Find(carId);

        Console.WriteLine("Enter start date DDMMYY");
        var dateOut = Console.ReadLine();
        Console.WriteLine("Enter end date DDMMYY");
        var dateIn = Console.ReadLine();

        db.Rentals.Add(new Rental()
        {
          CustomerId = customerId,
          CarId = carId,
          StartDate = DateTime.ParseExact(dateOut, "ddmmyy", null),
          EndDate = DateTime.ParseExact(dateIn, "ddmmyy", null),
          ReturnDate = DateTime.ParseExact("010101", "ddmmyy", null)
        });

        try
        {
          db.SaveChanges();
        }
        catch
        {
          Console.WriteLine("Sorry that car's not available");
          Console.ReadLine();
        }
      }
    }
  }
}