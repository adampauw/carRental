using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.PostgreSQL {

 public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int DL_Number { get; set; }
        public int phone_number { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }


    }
}