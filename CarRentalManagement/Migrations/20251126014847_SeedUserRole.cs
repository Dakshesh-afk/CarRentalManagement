using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9a294167-72c6-4d33-8665-63cd5b546d05", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJnr5SG3uvvANtRSb4rUmZ46vv9as77/Kh8V29zXSC2Vq1ntqJHUdGDrF6fNUOpzGQ==", null, false, "d9ca323f-6f4f-4667-8301-fa1a43da7573", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(7946), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(7975), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8529), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8535), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8714), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8720), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8724), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8729), new DateTime(2025, 11, 26, 9, 48, 45, 435, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(1918), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(1948), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(2495), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(3359), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4393), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4400), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4407), new DateTime(2025, 11, 26, 9, 19, 24, 654, DateTimeKind.Local).AddTicks(4410) });
        }
    }
}
