using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhosNextInfra.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AcceptIncommings", "CreatedAt", "DeletedAt", "ExternalCode", "Name", "UpdatedAt", "UpperId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8366), null, "1", "Receita", null, null },
                    { 2, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8381), null, "2", "Despesas", null, null },
                    { 7, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8386), null, "3", "Despesas bancárias", null, null },
                    { 8, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8387), null, "4", "Outras receitas", null, null },
                    { 3, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8382), null, "2.1", "Com pessoal", null, 2 },
                    { 4, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8383), null, "2.2", "Mensais", null, 2 },
                    { 5, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8384), null, "2.3", "Manutenção", null, 2 },
                    { 6, false, new DateTime(2023, 1, 31, 21, 31, 42, 623, DateTimeKind.Local).AddTicks(8385), null, "2.4", "Diversas", null, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
