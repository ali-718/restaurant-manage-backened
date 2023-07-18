using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Manage_Backened.Migrations
{
    /// <inheritdoc />
    public partial class RelationbetweenbanksandUsertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Banks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Banks_UserId",
                table: "Banks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Users_UserId",
                table: "Banks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Users_UserId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Banks_UserId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Banks");
        }
    }
}
