using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moving.EfDataAccess.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FirstName", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8141), "Lazar", "Martic" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8220), "J" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8228), "Boston" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8234), "Smit" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8240), "Douce" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8245), "Summer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8251), "Sinatra" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8256), "Old" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8261), "Fin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8266), "Jordan" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8271), "Boring" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(8277), "Falon" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 657, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 662, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 24, 36, 663, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedAt", "Password", "UserName" },
                values: new object[,]
                {
                    { 14, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3650), null, "fanta@gmail.com", "Fanta", false, false, "Stick", null, "sifra123", "fanta" },
                    { 15, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3721), null, "sam@gmail.com", "Sam", false, false, "Fisher", null, "sifra123", "sam" },
                    { 12, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3637), null, "mike@gmail.com", "Mike", false, false, "Luis", null, "sifra123", "mike" },
                    { 11, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3630), null, "donald@gmail.com", "Donald", false, false, "Trump", null, "sifra123", "donald" },
                    { 10, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3623), null, "pike@gmail.com", "Pike", false, false, "Hook", null, "sifra123", "pike" },
                    { 9, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3617), null, "boris@gmail.com", "Boris", false, false, "Malagurski", null, "sifra123", "boris" },
                    { 8, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3610), null, "anna@gmail.com", "Anna", false, false, "Shmit", null, "sifra123", "anna" },
                    { 7, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3604), null, "josh@gmail.com", "Josh", false, false, "Francis", null, "sifra123", "josh" },
                    { 6, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3597), null, "frank@gmail.com", "Frank", false, false, "Sinatra", null, "sifra123", "frank" },
                    { 5, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3590), null, "mike@gmail.com", "Mike", false, false, "Dean", null, "sifra123", "mike" },
                    { 4, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3582), null, "honny@gmail.com", "Jhonny", false, false, "Cash", null, "sifra123", "honny" },
                    { 3, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3572), null, "contractor@gmail.com", "Contractor", false, false, "Contractor", null, "sifra123", "contractor" },
                    { 2, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3508), null, "sales@gmail.com", "Sales", false, false, "Manager", null, "sifra123", "sale" },
                    { 13, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(3643), null, "dzim@gmail.com", "Dzim", false, false, "Sharp", null, "sifra123", "dzim" },
                    { 1, new DateTime(2020, 8, 22, 15, 24, 36, 664, DateTimeKind.Local).AddTicks(1705), null, "admin@gmail.com", "Admin", false, false, "Admin", null, "sifra123", "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FirstName", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9467), "LazarA", "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9555), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9564), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9571), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9577), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9584), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9590), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9596), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9602), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9608), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9614), "Young" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9621), "Young" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 344, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(548));
        }
    }
}
