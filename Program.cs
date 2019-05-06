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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═══════════════╗");
            Console.WriteLine("║ 1 List Module ║");
            
            Console.Write("Specify Model Name: ");
            
            var model = Console.ReadLine();

            using(var db = new CarRentalDBContext()) {
                db.Cars.Where(car => car.Model.Contains(model))
                    .ToList()
                    .ForEach(car => Console.WriteLine(car.Model));
            }
        }
    }
}