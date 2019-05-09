
namespace ConsoleApp.PostgreSQL {

 public class Rental
    {
        public int Id { get; set; }
        public int customer_id { get; set; }
        public int car_id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }

        public override string ToString() {
            return this.Id + "-" + this.Model;
        }

    }
}