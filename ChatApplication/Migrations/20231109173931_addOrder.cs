using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApplication.Migrations
{
    public partial class addOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    OrderPlacedTime = table.Column<DateTime>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    CustomerCNIC = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<string>(nullable: true),
                    ShipingMethod = table.Column<string>(nullable: true),
                    items = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
