
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace ConsoleApp.PostgreSQL {

 public class Rental
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}