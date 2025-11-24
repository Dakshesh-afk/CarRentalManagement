using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(8097), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(8126), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(8133), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(8134), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9558), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9570), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9577), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9578), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9822), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9824), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9828), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9829), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9834), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 11, 24, 16, 23, 44, 61, DateTimeKind.Local).AddTicks(9838), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
