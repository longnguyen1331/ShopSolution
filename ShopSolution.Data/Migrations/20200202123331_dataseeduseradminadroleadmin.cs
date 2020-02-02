using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class dataseeduseradminadroleadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("2ac8608b-747c-4a92-9372-a7ab59720611"), "984c1972-6a7c-4192-aeb2-73e4e34e69cb", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("6b502dd8-71de-41d5-9f8d-bd0924527c4e"), new Guid("2ac8608b-747c-4a92-9372-a7ab59720611") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6b502dd8-71de-41d5-9f8d-bd0924527c4e"), 0, "95001009-781a-414f-a081-4e680bbcc82d", new DateTime(1995, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "longnguyen13th1d.pou@gmail.com", true, "Nguyễn", "Long", false, null, "longnguyen13th1d.pou@gmail.com", "admin", "AQAAAAEAACcQAAAAEIe88wVemuclQa5jS0aAoGgkdySy+bcFVD1bl8Un7qp7UhhGTe+GhcbCpU3coZlwsg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 2, 19, 33, 30, 754, DateTimeKind.Local).AddTicks(9415));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ac8608b-747c-4a92-9372-a7ab59720611"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("6b502dd8-71de-41d5-9f8d-bd0924527c4e"), new Guid("2ac8608b-747c-4a92-9372-a7ab59720611") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b502dd8-71de-41d5-9f8d-bd0924527c4e"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 2, 19, 22, 22, 67, DateTimeKind.Local).AddTicks(3241));
        }
    }
}
