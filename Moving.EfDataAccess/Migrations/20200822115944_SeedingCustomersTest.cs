using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moving.EfDataAccess.Migrations
{
    public partial class SeedingCustomersTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedAt", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(6767), null, "mikey@gmail.com", "Mike", false, false, "Young", null, "38166415304" },
                    { 12, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9614), null, "ron@gmail.com", "Ron", false, false, "Young", null, "8166415304" },
                    { 11, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9608), null, "bruce@gmail.com", "Bruce", false, false, "Young", null, "752096535743" },
                    { 10, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9602), null, "amy@gmail.com", "Amy", false, false, "Young", null, "75209355743" },
                    { 9, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9596), null, "suzanne@gmail.com", "Suzanne", false, false, "Young", null, "398529358" },
                    { 8, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9590), null, "ana@gmail.com", "Anna", false, false, "Young", null, "7520935743" },
                    { 13, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9621), null, "jimmy@gmail.com", "Jimmy", false, false, "Young", null, "41284195" },
                    { 6, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9577), null, "josh@gmail.com", "Josh", false, false, "Young", null, "9128709845" },
                    { 5, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9571), null, "jack@gmail.com", "Jack", false, false, "Young", null, "0128377344" },
                    { 4, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9564), null, "adam@gmail.com", "Adam", false, false, "Young", null, "9859859585" },
                    { 3, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9555), null, "john@gmail.com", "John", false, false, "Young", null, "3838388585" },
                    { 2, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9467), null, "low@gmail.com", "LazarA", false, false, "Young", null, "321321321" },
                    { 7, new DateTime(2020, 8, 22, 13, 59, 44, 349, DateTimeKind.Local).AddTicks(9584), null, "jenny@gmail.com", "Jenny", false, false, "Young", null, "9558290385" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 519, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(828));
        }
    }
}
