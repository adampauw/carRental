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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔════════════════╗");
            Console.WriteLine("║ 1 Add Car      ║");
            Console.WriteLine("╚════════════════╝");
            Console.WriteLine("╔════════════════╗");
            Console.WriteLine("║ 2 Add Customer ║");
            Console.WriteLine("╚════════════════╝");
            Console.WriteLine("╔════════════════╗");
            Console.WriteLine("║ 3 Add Rental   ║");
            Console.WriteLine("╚════════════════╝");

            Console.Write("Choose an option: ");

            var option = Console.ReadLine();

            using (var db = new CarRentalDBContext())
            {
                db.Cars.Where(car => car.Model.Contains(model))
                    .ToList()
                    .ForEach(car => Console.WriteLine(car.Model));
            }
        }
    }
}

// add two more tables for customers and rentals. keys. and populate them .make a menu for users to populate database and use a loop to reiterate the menu