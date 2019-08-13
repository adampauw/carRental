using System;
using System.Linq;

namespace RentmanLib
{
  public class CustomerRepository
  {
    public void Add(string nameFirst, string namelast, int license, int phone)
    {
      using (var db = new CarRentalDBContext())
      {
        db.Customers.Add(new Customer()
        {
          first_name = nameFirst,
          last_name = namelast,
          DL_Number = license,
          phone_number = phone,
        });
        db.SaveChanges();
      }
    }

    public void Delete()
    {
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
          Console.WriteLine("This customer does not exist");
          Delete();
          return;
        }
        db.Customers.Remove(idRecieved);
        db.SaveChanges();
      }
    }

    public void Update()
    {
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

    public void List()
    {
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

  }
}