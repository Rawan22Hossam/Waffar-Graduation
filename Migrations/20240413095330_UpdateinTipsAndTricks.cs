using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Waffar.Migrations
{
    /// <inheritdoc />
    public partial class UpdateinTipsAndTricks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipsAndTricks_Admin_AdminId",
                table: "TipsAndTricks");

            migrationBuilder.DropIndex(
                name: "IX_TipsAndTricks_AdminId",
                table: "TipsAndTricks");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "TipsAndTricks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "TipsAndTricks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TipsAndTricks_AdminId",
                table: "TipsAndTricks",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipsAndTricks_Admin_AdminId",
                table: "TipsAndTricks",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
