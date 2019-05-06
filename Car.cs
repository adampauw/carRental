
namespace ConsoleApp.PostgreSQL {

 public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public override string ToString() {
            return this.Id + "-" + this.Model;
        }

    }
}