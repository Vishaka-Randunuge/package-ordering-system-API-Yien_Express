using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YienExpress.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "packages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_packages_OrderId",
                table: "packages",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderId",
                table: "customers",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_orders_OrderId",
                table: "customers",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_packages_orders_OrderId",
                table: "packages",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_orders_OrderId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_packages_orders_OrderId",
                table: "packages");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropIndex(
                name: "IX_packages_OrderId",
                table: "packages");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "packages");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "customers");
        }
    }
}
