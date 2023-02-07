using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YienExpress.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_orders_OrderId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_packages_orders_OrderId",
                table: "packages");

            migrationBuilder.DropIndex(
                name: "IX_packages_OrderId",
                table: "packages");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "EDate",
                table: "packages");

            migrationBuilder.DropColumn(
                name: "MDate",
                table: "packages");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "packages");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "RecorderLevel",
                table: "packages",
                newName: "ReorderLevel");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "packages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfDelivery",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DateOfOrder",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customerName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customerTel",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "deliveryLocation",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "packageName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "trackStatus",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "packages");

            migrationBuilder.DropColumn(
                name: "DateOfDelivery",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "DateOfOrder",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "customerName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "customerTel",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "deliveryLocation",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "packageName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "trackStatus",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "ReorderLevel",
                table: "packages",
                newName: "RecorderLevel");

            migrationBuilder.AddColumn<DateTime>(
                name: "EDate",
                table: "packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MDate",
                table: "packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "packages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "customers",
                type: "int",
                nullable: true);

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
    }
}
