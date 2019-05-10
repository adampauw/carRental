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

            Console.Write("Choose an option number: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch(selection) {
                case 1:
                    Console.WriteLine("This is option 1");
                    break;
                case 2:
                    Console.WriteLine("This is option 2");
                    break;
                case 3:
                    Console.WriteLine("This is option 3");
                    break;
                default: 
                    Console.WriteLine("Thats not an option you fool");
                    break;
            }

            // var option = Console.ReadLine();

            // using (var db = new CarRentalDBContext())
            // {
            //     // db.Cars.Where(car => car.Model.Contains(model))
            //     //     .ToList()
            //     //     .ForEach(car => Console.WriteLine(car.Model));
            // }
        }
    }
}

//and populate them .make a menu for users to populate database and use a loop to reiterate the menu