using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RentmanLib;

namespace ConsoleApp.PostgreSQL
{
    class Program
    {
        static CarRepository carRepo = new RentmanLib.CarRepository();
        static CustomerRepository custRepo = new RentmanLib.CustomerRepository();
        static RentalRepository rentalRepo = new RentmanLib.RentalRepository();
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
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What colour is it?");
            var colour = Console.ReadLine();
            Console.WriteLine("Whats the odometer reading?");
            var mile = Convert.ToInt32(Console.ReadLine());
            carRepo.Add(make, model, year, colour, mile);
        }

        private static void DeleteCar()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            carRepo.Delete();

        }

        private static void UpdateCar()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            carRepo.Update();

        }


        private static void ListCars()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            carRepo.List();
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
            var license = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phone number");
            var phone = Convert.ToInt32(Console.ReadLine());
            custRepo.Add(nameFirst, namelast, license, phone);
        }

        private static void DeleteCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            custRepo.Delete();
        }

        private static void UpdateCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            custRepo.Update();
        }

        private static void ListCustomers()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            custRepo.List();
        }


        // ------------ Rental Functions ------------

        static void RentalMenu()
        {
            AddRental();
        }

        private static void AddRental()

        {
            Console.WriteLine("");
            Console.WriteLine("");
            rentalRepo.Add();
        }
    }
}


