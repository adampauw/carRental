
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentmanLib
{
  public class CarRepository
  {
    public void Add(string model, string make, int year, string colour, int mile)
    {
      using (var db = new CarRentalDBContext())
      {
        var newCar = db.Cars.Add(new Car()
        {
          Make = make,
          Model = model,
          Year = year,
          Colour = colour,
          Milage = mile
        });
        db.SaveChanges();
      }
    }

    public void Delete()
    {
      using (var db = new CarRentalDBContext())
      {
        db.Cars
       .ToList()
       .ForEach(car => Console.WriteLine("Id:" + car.Id + "  " + car.Make + " " + car.Model));
        Console.WriteLine("");
        Console.WriteLine("Specify which car ID to remove: ");
        int carId = Int32.Parse(Console.ReadLine());
        Console.WriteLine(carId);
        var returnedCar = db.Cars.FirstOrDefault(car => car.Id.Equals(carId));
        if (returnedCar == null)
        {
          Console.WriteLine("");
          Console.WriteLine("This car does not exist");
          Delete();
          return;
        }
        db.Cars.Remove(returnedCar);
        db.SaveChanges();
      }
    }

    public void Update()
    {
      using (var db = new CarRentalDBContext())

      {
        char selection;

        db.Cars
            .ToList()
            .ForEach(car => Console.WriteLine("Id:" + car.Id + "  " + car.Make + " " + car.Model));
        Console.WriteLine("");
        Console.WriteLine("Enter Id of the car you wish to modify");
        int carId = Convert.ToInt32(Console.ReadLine());
        var foundCar = db.Cars.Find(carId);
        Console.WriteLine("");
        Console.WriteLine("Choose the field you wish to modify");
        Console.WriteLine("");
        Console.WriteLine("╔══════════╗ ╔═══════════╗ ╔═══════════╗ ╔═══════════╗ ╔═══════════╗");
        Console.WriteLine("║ 1. Make  ║ ║  2. Model ║ ║  3. Year  ║ ║ 4. Colour ║ ║ 5. Milage ║");
        Console.WriteLine("╚══════════╝ ╚═══════════╝ ╚═══════════╝ ╚═══════════╝ ╚═══════════╝");
        selection = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        switch (selection)
        {
          case '1':
            Console.WriteLine("");
            Console.WriteLine("Enter the new Make");
            foundCar.Make = Console.ReadLine();
            Console.WriteLine("");
            db.SaveChanges();
            Console.WriteLine("Car's Make has been successfully updated!");
            break;

          case '2':
            Console.WriteLine("");
            Console.WriteLine("Enter the new Model");
            foundCar.Model = Console.ReadLine();
            Console.WriteLine("");
            db.SaveChanges();
            Console.WriteLine("Car's Model has been successfully updated!");
            break;

          case '3':
            Console.WriteLine("");
            Console.WriteLine("Enter the new Year");
            foundCar.Year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            db.SaveChanges();
            Console.WriteLine("Car's Year has been successfully updated!");
            break;

          case '4':
            Console.WriteLine("");
            Console.WriteLine("Enter the new Colour");
            foundCar.Colour = Console.ReadLine();
            Console.WriteLine("");
            db.SaveChanges();
            Console.WriteLine("Car's Colour has been successfully updated!");
            break;

          case '5':
            Console.WriteLine("");
            Console.WriteLine("Enter the new Milage");
            foundCar.Milage = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            db.SaveChanges();
            Console.WriteLine("Car's Milage has been successfully updated!");
            break;

          case 'q':
            Console.WriteLine("");
            Console.WriteLine("Quitting now");
            break;

          default:
            Console.WriteLine("");
            Console.WriteLine("Thats not an option you fool");
            break;
        }
      }
    }

    public List<Car> List()
    {
      using (var db = new CarRentalDBContext())
      {
        return db.Cars.ToList();
       
      }
    }
  }
}

 //     .ForEach(car => Console.WriteLine("Id:" + car.Id + "  " + car.Make + " " + car.Model));
        // Console.WriteLine("");
        // Console.WriteLine("Press enter to return to Car menu");
        // Console.ReadLine();