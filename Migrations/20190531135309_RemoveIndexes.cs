using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentman.Migrations
{
    public partial class RemoveIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_ReturnDate",
                table: "Rentals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Rentals",
                nullable: true,
                oldClrType: typeof(DateTime));

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Rentals",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_ReturnDate",
                table: "Rentals",
                column: "ReturnDate");
        }
    }
}
