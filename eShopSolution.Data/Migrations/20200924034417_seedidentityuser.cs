using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class seedidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 24, 10, 44, 16, 654, DateTimeKind.Local).AddTicks(4517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 24, 10, 24, 14, 885, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7f4526bc-b553-4eca-a673-9881bb88101d"), "fb21fa3a-5b40-4239-8525-e13b326f5792", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("518eed54-b412-4798-9d0f-5befff81a122"), new Guid("7f4526bc-b553-4eca-a673-9881bb88101d") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FisrtName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("518eed54-b412-4798-9d0f-5befff81a122"), 0, "f9d1fced-81e8-41b1-a8b5-5f3dcacf3b30", new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "bnpham1993@gmail.com", true, "Pham", "Bui", false, null, "bnpham1993@gmail.com", "admin", "AQAAAAEAACcQAAAAEFXRLumzVIi3JjoJ55HaijziT0O8VL8maYs9csf/EDZnRbSG3fUw5EnHNAYzY/fCpQ==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 9, 24, 10, 44, 16, 681, DateTimeKind.Local).AddTicks(3257));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7f4526bc-b553-4eca-a673-9881bb88101d"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("518eed54-b412-4798-9d0f-5befff81a122"), new Guid("7f4526bc-b553-4eca-a673-9881bb88101d") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("518eed54-b412-4798-9d0f-5befff81a122"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 24, 10, 24, 14, 885, DateTimeKind.Local).AddTicks(9826),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 24, 10, 44, 16, 654, DateTimeKind.Local).AddTicks(4517));

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
                value: new DateTime(2020, 9, 24, 10, 24, 14, 911, DateTimeKind.Local).AddTicks(4911));
        }
    }
}
