using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar_Praksa.Dal.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CreatedAt", "CreatedBy", "ModifideAt" },
                values: new object[,]
                {
                    { 1, "Bugojno", new DateTime(2020, 10, 22, 22, 4, 16, 892, DateTimeKind.Utc).AddTicks(1955), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Sarajevo", new DateTime(2020, 10, 22, 22, 4, 16, 892, DateTimeKind.Utc).AddTicks(2350), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Mostar", new DateTime(2020, 10, 22, 22, 4, 16, 892, DateTimeKind.Utc).AddTicks(2364), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifideAt", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 23, 0, 4, 16, 907, DateTimeKind.Local).AddTicks(8454), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator" },
                    { 2, new DateTime(2020, 10, 23, 0, 4, 16, 907, DateTimeKind.Local).AddTicks(8567), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityID", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "ModifideAt", "Name", "Password", "Surname", "Username" },
                values: new object[] { 1, "Prusac bb 70223", 1, new DateTime(2020, 10, 22, 22, 4, 16, 898, DateTimeKind.Utc).AddTicks(3962), "Terzic", new DateTime(1999, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmedterzic@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed", "ahmed123", "Terzic", "Terzic" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityID", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "ModifideAt", "Name", "Password", "Surname", "Username" },
                values: new object[] { 2, "Logavina br. 21", 2, new DateTime(2020, 10, 22, 22, 4, 16, 898, DateTimeKind.Utc).AddTicks(4117), "Terzic", new DateTime(1998, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "nijedoe@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "jihn123", "NijeDOE", "NijeDOE" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "ModifideAt", "Question", "Response", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 23, 0, 4, 16, 899, DateTimeKind.Local).AddTicks(8840), "Terzic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koliko dugo mogu da rentam vozilo?", null, 2 },
                    { 2, new DateTime(2020, 10, 23, 0, 4, 16, 905, DateTimeKind.Local).AddTicks(4287), "Terzic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da li su vozila odrzavana redovno?", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifideAt", "RoleID", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 23, 0, 4, 16, 909, DateTimeKind.Local).AddTicks(3870), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2020, 10, 23, 0, 4, 16, 909, DateTimeKind.Local).AddTicks(4750), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
