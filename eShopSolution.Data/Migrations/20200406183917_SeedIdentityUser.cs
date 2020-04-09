using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 7, 1, 39, 16, 346, DateTimeKind.Local).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 7, 1, 22, 30, 696, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("872e6d3b-071b-44ae-a907-a336afb19aac"), "73385239-b708-4e94-9080-2dec21178475", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("4e2df197-539c-469f-89ba-29003f984868"), new Guid("872e6d3b-071b-44ae-a907-a336afb19aac") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4e2df197-539c-469f-89ba-29003f984868"), 0, "3e0d37d0-bb26-44a1-be32-9aaaf1cf1a65", new DateTime(1994, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangit94bg@gmail.com", true, "Ngo", "Hoang", false, null, "hoangit94bg@gmail.com", "admin", "AQAAAAEAACcQAAAAEL6+8+uTwaLonjqnrZi5bkhhG7YeZufdbq41te31J87nrCR4rWFz9ePvU3oXp1NcUg==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 4, 7, 1, 39, 16, 381, DateTimeKind.Local).AddTicks(9087));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("872e6d3b-071b-44ae-a907-a336afb19aac"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4e2df197-539c-469f-89ba-29003f984868"), new Guid("872e6d3b-071b-44ae-a907-a336afb19aac") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e2df197-539c-469f-89ba-29003f984868"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 7, 1, 22, 30, 696, DateTimeKind.Local).AddTicks(8541),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 7, 1, 39, 16, 346, DateTimeKind.Local).AddTicks(2758));

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
                value: new DateTime(2020, 4, 7, 1, 22, 30, 736, DateTimeKind.Local).AddTicks(5819));
        }
    }
}
