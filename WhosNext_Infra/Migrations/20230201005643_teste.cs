using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhosNextInfra.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 56, 42, 960, DateTimeKind.Local).AddTicks(5953));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8387));
        }
    }
}
