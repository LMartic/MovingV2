using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moving.EfDataAccess.Migrations
{
    public partial class hell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[] { 14, new DateTime(2020, 8, 21, 15, 6, 3, 521, DateTimeKind.Local).AddTicks(4963), null, "Delete Job Review", false, false, null, "Delete Job Review" });

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

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[] { 14, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 399, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 14, 31, 7, 401, DateTimeKind.Local).AddTicks(1917));
        }
    }
}
