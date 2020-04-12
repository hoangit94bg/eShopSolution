using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("872e6d3b-071b-44ae-a907-a336afb19aac"),
                column: "ConcurrencyStamp",
                value: "b1529384-cd40-42a0-8d8a-519a0aaeea24");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e2df197-539c-469f-89ba-29003f984868"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d573e54-c1fe-421a-9f5d-ee02b1a23dfe", "AQAAAAEAACcQAAAAEEwjueLdrQqBIXoHplVHGTeAqE44k1hgtwEz1G+QHMIKtCCsZ43MORwm9+ISdxoU7Q==" });

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
                value: new DateTime(2020, 4, 12, 18, 6, 31, 447, DateTimeKind.Local).AddTicks(4512));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("872e6d3b-071b-44ae-a907-a336afb19aac"),
                column: "ConcurrencyStamp",
                value: "735b95d8-9e1f-4a25-9641-7be2109f95a2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e2df197-539c-469f-89ba-29003f984868"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbc0888d-30e7-41b9-a99f-6ea81333af8b", "AQAAAAEAACcQAAAAENoIrma3/0MRlS14Mn1+M4Yg/L2KsmH8x6sQzdYpKK7zkk7FTsGUkW6DXELiAO2xqQ==" });

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
                value: new DateTime(2020, 4, 11, 0, 31, 12, 125, DateTimeKind.Local).AddTicks(6145));
        }
    }
}
