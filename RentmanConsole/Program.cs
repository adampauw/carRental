using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RentmanLib;

namespace ConsoleApp.PostgreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void Title()
        {
            Console.WriteLine("  ____  ____  __ _  ____        _  _   __   __ _ ");
            Console.WriteLine(@" (  _ \(  __)(  ( \(_  _) ___  ( \/ ) / _\ (  ( \ ");
            Console.WriteLine(@"  )   / ) _) /    /  )(  (___) / \/ \/    \/    / ");
            Console.WriteLine(@" (__\_)(____)\_)__) (__)       \_)(_/\_/\_/\_)__) ");
            Console.WriteLine("");
        }


        static void MainMenu()
        {
            char selection;
            do
            {
                Console.Clear();
                Title();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════╗");
                Console.WriteLine("║ 1 Car Menu      ║");
                Console.WriteLine("╚═════════════════╝");
                Console.WriteLine("╔═════════════════╗");
                Console.WriteLine("║ 2 Customer Menu ║");
                Console.WriteLine("╚═════════════════╝");
                Console.WriteLine("╔═════════════════╗");
                Console.WriteLine("║ 3 Rental Menu   ║");
                Console.WriteLine("╚═════════════════╝");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Choose an option number: ");
                Console.Write("");
                Console.Write("");
                Console.Write("");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                switch (selection)
                {
                    case '1': CarMenu(); break;
                    case '2': CustomerMenu(); break;
                    case '3': RentalMenu(); break;
                    case 'q':
                        Console.WriteLine("Quitting now");
                        break;
                    default:
                        Console.WriteLine("Thats not an option you fool");
                        break;
                }
            } while (selection != 'q');
        }

        // ------------ Car Functions ------------

        private static void CarMenu()
        {
            char selection;
            do
            {
                Console.Clear();
                Title();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 1 Add Car      ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 2 Delete Car   ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 3 Update Car   ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 4 List Cars    ║");
                Console.WriteLine("╚════════════════╝");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║ 5 Main Menu    ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Choose an option number: ");
                Console.Beep();
                Console.Write("");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                switch (selection)
                {
                    case '1': AddCar(); break;
                    case '2': DeleteCar(); break;
                    case '3': UpdateCar(); break;
                    case '4': ListCars(); break;
                    case '5': MainMenu(); break;
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

        private static void UpdateCar()
        {
            Console.WriteLine("");
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


        private static void ListCars()
        {
            Console.WriteLine("");
            using (var db = new CarRentalDBContext())
            {
                db.Cars
                    .ToList()
                    .ForEach(car => Console.WriteLine("Id:" + car.Id + "  " + car.Make + " " + car.Model));
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to Car menu");
                Console.ReadLine();
            }
        }


        // ------------ Customer Functions ------------


        private static void CustomerMenu()
        {
            char selection;
            do
            {
                Console.Clear();
                Title();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("╔═══════════════════╗");
                Console.WriteLine("║ 1 Add Customer    ║");
                Console.WriteLine("╚═══════════════════╝");
                Console.WriteLine("╔═══════════════════╗");
                Console.WriteLine("║ 2 Delete Customer ║");
                Console.WriteLine("╚═══════════════════╝");
                Console.WriteLine("╔═══════════════════╗");
                Console.WriteLine("║ 3 Update Customer ║");
                Console.WriteLine("╚═══════════════════╝");
                Console.WriteLine("╔═══════════════════╗");
                Console.WriteLine("║ 4 List Customers  ║");
                Console.WriteLine("╚═══════════════════╝");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("╔═══════════════════╗");
                Console.WriteLine("║ 5 Main Menu       ║");
                Console.WriteLine("╚═══════════════════╝");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Choose an option number: ");
                Console.Beep();
                Console.Write("");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                switch (selection)
                {
                    case '1': AddCustomer(); break;
                    case '2': DeleteCustomer(); break;
                    case '3': UpdateCustomer(); break;
                    case '4': ListCustomers(); break;
                    case '5': MainMenu(); break;
                    case 'q':
                        Console.WriteLine("Quitting now");
                        break;
                    default:
                        Console.WriteLine("Thats not an option you fool");
                        break;
                }
            } while (selection != 'q');
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
            using (var db = new CarRentalDBContext())
            {
                db.Customers.Add(new Customer()
                {
                    first_name = nameFirst,
                    last_name = namelast,
                    DL_Number = Convert.ToInt32(license),
                    phone_number = Convert.ToInt32(phone),
                });
                db.SaveChanges();
            }
        }

        private static void DeleteCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            using (var db = new CarRentalDBContext())
            {
                db.Customers
               .ToList()
               .ForEach(Customer => Console.WriteLine("Id:" + Customer.Id + "  " + Customer.first_name + " " + Customer.last_name));
                Console.WriteLine("");
                Console.WriteLine("Specify which Customer ID to remove: ");
                int customerId = Int32.Parse(Console.ReadLine());
                Console.WriteLine(customerId);
                var idRecieved = db.Customers.FirstOrDefault(Customer => Customer.Id.Equals(customerId));
                if (idRecieved == null)
                {
                    Console.WriteLine("");
                    Console.WriteLine("This car does not exist");
                    DeleteCar();
                    return;
                }
                db.Customers.Remove(idRecieved);
                db.SaveChanges();
            }
        }

        private static void UpdateCustomer()
        {
            Console.WriteLine("");
            using (var db = new CarRentalDBContext())

            {
                char selection;

                db.Customers
                    .ToList()
                    .ForEach(Customer => Console.WriteLine("Id:" + Customer.Id + "  " + Customer.first_name + " " + Customer.last_name));
                Console.WriteLine("");
                Console.WriteLine("Enter Id of the Customer you wish to modify");
                int customerId = Convert.ToInt32(Console.ReadLine());
                var foundCustomer = db.Customers.Find(customerId);
                Console.WriteLine("");
                Console.WriteLine("Choose the field you wish to modify");
                Console.WriteLine("");
                Console.WriteLine("╔═══════════════╗ ╔══════════════╗ ╔═════════════╗ ╔═════════════╗ ");
                Console.WriteLine("║ 1. First Name ║ ║ 2. Last Name ║ ║    3. DL    ║ ║  4. Phone   ║ ");
                Console.WriteLine("╚═══════════════╝ ╚══════════════╝ ╚═════════════╝ ╚═════════════╝ ");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                switch (selection)
                {
                    case '1':
                        Console.WriteLine("");
                        Console.WriteLine("Enter the new First Name");
                        foundCustomer.first_name = Console.ReadLine();
                        Console.WriteLine("");
                        db.SaveChanges();
                        Console.WriteLine("Customer's First Name has been successfully updated!");
                        break;

                    case '2':
                        Console.WriteLine("");
                        Console.WriteLine("Enter the new Last Name");
                        foundCustomer.last_name = Console.ReadLine();
                        Console.WriteLine("");
                        db.SaveChanges();
                        Console.WriteLine("Customer's Last Name has been successfully updated!");
                        break;

                    case '3':
                        Console.WriteLine("");
                        Console.WriteLine("Enter the new Drivers License");
                        foundCustomer.DL_Number = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        db.SaveChanges();
                        Console.WriteLine("Customer's Drivers License has been successfully updated!");
                        break;

                    case '4':
                        Console.WriteLine("");
                        Console.WriteLine("Enter the new Phone Number");
                        foundCustomer.phone_number = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        db.SaveChanges();
                        Console.WriteLine("Customer's Phone Number has been successfully updated!");
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

        private static void ListCustomers()
        {
            Console.WriteLine("");
            using (var db = new CarRentalDBContext())
            {
                db.Customers
                    .ToList()
                    .ForEach(Customer => Console.WriteLine("Id:" + Customer.Id + "  " + Customer.first_name + " " + Customer.last_name));
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to Customer menu");
                Console.ReadLine();
            }
        }
        // ------------ Rental Functions ------------

        static void RentalMenu()
        {
            AddRental();
        }

        private static void AddRental()

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





/* 
    Try again the unique index
    Try to get menu with level and loop and arrays
*/


