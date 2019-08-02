using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentmanLib.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("StartDate", "Rentals");
            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Rentals",
                nullable: true
            );
            
            migrationBuilder.DropColumn("EndDate", "Rentals");
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Rentals",
                nullable: true
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Rentals",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "Rentals",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
