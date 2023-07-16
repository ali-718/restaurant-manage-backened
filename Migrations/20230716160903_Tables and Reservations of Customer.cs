using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Manage_Backened.Migrations
{
    /// <inheritdoc />
    public partial class TablesandReservationsofCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Inventories_InventoryId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_InventoryId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "IngredientsInventory",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsInventory", x => new { x.IngredientsId, x.InventoryId });
                    table.ForeignKey(
                        name: "FK_IngredientsInventory_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientsInventory_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsInventory_InventoryId",
                table: "IngredientsInventory",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientsInventory");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_InventoryId",
                table: "Ingredients",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Inventories_InventoryId",
                table: "Ingredients",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id");
        }
    }
}
