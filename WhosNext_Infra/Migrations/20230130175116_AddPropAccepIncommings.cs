using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhosNextInfra.Migrations
{
    /// <inheritdoc />
    public partial class AddPropAccepIncommings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcceptIncommings",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptIncommings",
                table: "Accounts");
        }
    }
}
