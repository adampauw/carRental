using Microsoft.EntityFrameworkCore.Migrations;

namespace RentmanLib.Migrations
{
    public partial class AddUniqueColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rentals_ReturnDate_CarId",
                table: "Rentals",
                columns: new[] { "ReturnDate", "CarId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rentals_ReturnDate_CarId",
                table: "Rentals");
        }
    }
}
