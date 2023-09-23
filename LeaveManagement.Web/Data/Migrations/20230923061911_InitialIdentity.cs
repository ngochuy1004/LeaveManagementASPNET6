using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class InitialIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b60a25c-1623-4161-b544-b4c14163b120", "82880406-1576-4200-86f8-603c88df4b59", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-ba12-1acb431eabc1", "e10cc333-f494-431c-a080-eefb1f507f2c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4631bd-f907-4409-b416-ba356312e678", 0, "639fbd60-ed93-40ae-b471-f5311f75646b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAu1ju8a+YPrXIzVZjz5/EqyXnnXkcu6/PSNS9YL2T/9SyKmxZuuCq79iwowdfUr0A==", null, false, "f3d2f4ba-8ea1-4c23-a99f-0ff15b419a1a", false, "user@localhost.com" },
                    { "408aa945-3d84-4421-8342-7269ec64d947", 0, "e8b8d264-9c54-4639-a84a-3cc6dff79055", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHdrxqLZ5mPAkh2vX2OQ5cXmY8k9RN6qNAJLEVbSZVY1jti6lptZTU2h3BRq94c2JA==", null, false, "3e3926da-6350-401c-a2d3-aa0b88d95cf8", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-ba12-1acb431eabc1", "3f4631bd-f907-4409-b416-ba356312e678" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b60a25c-1623-4161-b544-b4c14163b120", "408aa945-3d84-4421-8342-7269ec64d947" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-ba12-1acb431eabc1", "3f4631bd-f907-4409-b416-ba356312e678" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b60a25c-1623-4161-b544-b4c14163b120", "408aa945-3d84-4421-8342-7269ec64d947" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b60a25c-1623-4161-b544-b4c14163b120");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-ba12-1acb431eabc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e678");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d947");
        }
    }
}
