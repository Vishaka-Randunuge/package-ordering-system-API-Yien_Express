using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YienExpress.Migrations
{
    /// <inheritdoc />
    public partial class tenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "trackStatus",
                table: "orders",
                newName: "tracking");

            migrationBuilder.RenameColumn(
                name: "deliveryLocation",
                table: "orders",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "customerTel",
                table: "orders",
                newName: "cPhone");

            migrationBuilder.RenameColumn(
                name: "customerName",
                table: "orders",
                newName: "cName");

            migrationBuilder.RenameColumn(
                name: "DateOfOrder",
                table: "orders",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "DateOfDelivery",
                table: "orders",
                newName: "DeliveryDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tracking",
                table: "orders",
                newName: "trackStatus");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "orders",
                newName: "DateOfOrder");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "orders",
                newName: "deliveryLocation");

            migrationBuilder.RenameColumn(
                name: "cPhone",
                table: "orders",
                newName: "customerTel");

            migrationBuilder.RenameColumn(
                name: "cName",
                table: "orders",
                newName: "customerName");

            migrationBuilder.RenameColumn(
                name: "DeliveryDate",
                table: "orders",
                newName: "DateOfDelivery");
        }
    }
}
