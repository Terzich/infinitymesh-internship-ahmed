using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar_Praksa.Dal.Migrations
{
    public partial class FixingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "BookedCars");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "BookedCars",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CommentCreated",
                table: "BookedCars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "BookedCars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8239), new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8365), new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 657, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 661, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 663, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 663, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 656, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 656, DateTimeKind.Utc).AddTicks(6064));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "BookedCars");

            migrationBuilder.DropColumn(
                name: "CommentCreated",
                table: "BookedCars");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "BookedCars");

            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "BookedCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    BookedCarID = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.BookedCarID);
                    table.ForeignKey(
                        name: "FK_Reviews_BookedCars_BookedCarID",
                        column: x => x.BookedCarID,
                        principalTable: "BookedCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(6517), new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(6708), new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 665, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 665, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 665, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 613, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 613, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 613, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 0, 3, 21, 634, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 0, 3, 21, 639, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 0, 3, 21, 644, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 0, 3, 21, 644, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 632, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 23, 3, 21, 632, DateTimeKind.Utc).AddTicks(3830));
        }
    }
}
