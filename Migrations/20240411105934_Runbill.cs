using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Waffar.Migrations
{
    /// <inheritdoc />
    public partial class Runbill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Bills",
                newName: "BillDescription");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Bills",
                newName: "BillDueDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BillDueDate",
                table: "Bills",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "BillDescription",
                table: "Bills",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
