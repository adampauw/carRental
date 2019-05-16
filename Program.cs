using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.PostgreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            char selection;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 1 Add Car      ║");
                Console.WriteLine("╚════════════════╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 2 Add Customer ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 3 Add Rental   ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 4  List Cars   ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 5  Delete Car  ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("");

                Console.Write("Choose an option number: ");
                Console.Beep();
                Console.Write("");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                switch (selection)
                {
                    case '1': AddCar(); break;
                    case '2': AddCustomer(); break;
                    case '4': ListCars(); break;
                    case '5': DeleteCar(); break;
                    case 'q':
                        Console.WriteLine("Quitting now");
                        break;
                    default:
                        Console.WriteLine("Thats not an option you fool");
                        break;
                }
            } while (selection != 'q');
        }

        private static void AddCar()
        {
            Console.WriteLine("");
            Console.WriteLine("Specify Make: ");
            var make = Console.ReadLine();
            Console.WriteLine("Specify Model: ");
            var model = Console.ReadLine();
            Console.WriteLine("and now the Year: ");
            var year = Console.ReadLine();
            Console.WriteLine("What colour is it?");
            var colour = Console.ReadLine();
            Console.WriteLine("Whats the odometer reading?");
            var mile = Console.ReadLine();
            using (var db = new CarRentalDBContext())
            {
                //Car car = new Car();
                //car.Make = make;
                //db.Cars.Add(car);

                db.Cars.Add(new Car()
                {
                    Make = make,
                    Model = model,
                    Year = Convert.ToInt32(year),
                    Colour = colour,
                    Milage = Convert.ToInt32(mile)
                });
                db.SaveChanges();
            }
        }

        private static void AddCustomer()
        {
            Console.WriteLine("First Name: ");
            var nameFirst = Console.ReadLine();
            Console.WriteLine("Last name: ");
            var namelast = Console.ReadLine();
            Console.WriteLine("Drivers License: ");
            var license = Console.ReadLine();
            Console.WriteLine("Phone number");
            var phone = Console.ReadLine();
        }

        private static void ListCars()
        {
            Console.WriteLine("");
            using (var db = new CarRentalDBContext())
            {
                db.Cars
                    .ToList()
                    .ForEach(car => Console.WriteLine("Id:" + car.Id + "  " + car.Make + " " + car.Model));
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to main menu");
                Console.ReadLine();
            }
        }

        private static void DeleteCar()
        {
            Console.WriteLine("");
            Console.WriteLine("");
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
                    DeleteCar();
                    return;
                }
                db.Cars.Remove(returnedCar);
                db.SaveChanges();
            }
        }
    }
}

// make it pretty, add cars, list cars, remove cars, rent cars? update cars? 
