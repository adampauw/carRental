using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentman.Migrations
{
    public partial class AddForeignKeysToRentalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "Rentals",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "Rentals",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Rentals",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "car_id",
                table: "Rentals",
                newName: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Rentals",
                newName: "start_date");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Rentals",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Rentals",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Rentals",
                newName: "car_id");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Rentals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Rentals",
                nullable: true);
        }
    }
}
