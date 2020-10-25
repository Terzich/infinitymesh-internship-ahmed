using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar_Praksa.Dal.Migrations
{
    public partial class DataSeedingv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleID",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Users_UserID",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_RoleID",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "ModifideAt",
                table: "UserRole");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UserID",
                table: "UserRoles",
                newName: "IX_UserRoles_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "RoleID", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifideAt = table.Column<DateTime>(nullable: false),
                    ColorName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifideAt = table.Column<DateTime>(nullable: false),
                    CarName = table.Column<string>(nullable: false),
                    YearOFProduction = table.Column<int>(nullable: false),
                    HorsePower = table.Column<int>(nullable: false),
                    NumberOfDoors = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    ColorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedCars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifideAt = table.Column<DateTime>(nullable: false),
                    CarID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    ReviewID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedCars_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedCars_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    BookedCarID = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorName", "CreatedAt", "CreatedBy", "ModifideAt" },
                values: new object[,]
                {
                    { 1, "Metalik siva", new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6330), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Metalik crna", new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6434), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Metalik crvena", new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6438), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Mat crna", new DateTime(2020, 10, 25, 23, 3, 21, 658, DateTimeKind.Utc).AddTicks(6441), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "ColorID", "CreatedAt", "CreatedBy", "HorsePower", "ImageURL", "ModifideAt", "NumberOfDoors", "Price", "YearOFProduction" },
                values: new object[] { 1, "Mercedes Benz E220", 1, new DateTime(2020, 10, 25, 23, 3, 21, 665, DateTimeKind.Utc).AddTicks(2967), "Terzic", 131, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 150m, 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "ColorID", "CreatedAt", "CreatedBy", "HorsePower", "ImageURL", "ModifideAt", "NumberOfDoors", "Price", "YearOFProduction" },
                values: new object[] { 2, "Mercedes Benz C220", 2, new DateTime(2020, 10, 25, 23, 3, 21, 665, DateTimeKind.Utc).AddTicks(3159), "Terzic", 131, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 110m, 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "ColorID", "CreatedAt", "CreatedBy", "HorsePower", "ImageURL", "ModifideAt", "NumberOfDoors", "Price", "YearOFProduction" },
                values: new object[] { 3, "Volkswagen Golf VII", 3, new DateTime(2020, 10, 25, 23, 3, 21, 665, DateTimeKind.Utc).AddTicks(3165), "Terzic", 111, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 120m, 2016 });

            migrationBuilder.InsertData(
                table: "BookedCars",
                columns: new[] { "Id", "CarID", "CreatedAt", "CreatedBy", "From", "ModifideAt", "ReviewID", "To", "TotalPrice", "UserID" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(6517), "Terzic", new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(4673), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 2 });

            migrationBuilder.InsertData(
                table: "BookedCars",
                columns: new[] { "Id", "CarID", "CreatedAt", "CreatedBy", "From", "ModifideAt", "ReviewID", "To", "TotalPrice", "UserID" },
                values: new object[] { 2, 3, new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(6708), "Terzic", new DateTime(2020, 10, 25, 23, 3, 21, 677, DateTimeKind.Utc).AddTicks(6643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 360m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_BookedCars_CarID",
                table: "BookedCars",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_BookedCars_UserID",
                table: "BookedCars",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorID",
                table: "Cars",
                column: "ColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "BookedCars");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleID", "UserID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleID", "UserID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRole",
                newName: "IX_UserRole_UserID");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserRole",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "UserRole",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifideAt",
                table: "UserRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 22, 22, 4, 16, 892, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 22, 22, 4, 16, 892, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 22, 22, 4, 16, 892, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 0, 4, 16, 899, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 0, 4, 16, 905, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 0, 4, 16, 907, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 0, 4, 16, 907, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifideAt", "RoleID", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 23, 0, 4, 16, 909, DateTimeKind.Local).AddTicks(3870), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2020, 10, 23, 0, 4, 16, 909, DateTimeKind.Local).AddTicks(4750), "Terzic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 22, 22, 4, 16, 898, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 22, 22, 4, 16, 898, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleID",
                table: "UserRole",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleID",
                table: "UserRole",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Users_UserID",
                table: "UserRole",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
