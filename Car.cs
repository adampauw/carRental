
using System.Collections.Generic;

namespace ConsoleApp.PostgreSQL {

 public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public int Milage { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
        
        public override string ToString() {
            return this.Id + "-" + this.Model;
        }

    }
}