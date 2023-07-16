using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Manage_Backened.Migrations
{
    /// <inheritdoc />
    public partial class DiningandCustomerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Orders_OrdersId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_OrdersId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Menus");

            migrationBuilder.CreateTable(
                name: "MenuOrders",
                columns: table => new
                {
                    MenusId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOrders", x => new { x.MenusId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_MenuOrders_Menus_MenusId",
                        column: x => x.MenusId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuOrders_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuOrders_OrdersId",
                table: "MenuOrders",
                column: "OrdersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuOrders");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrdersId",
                table: "Menus",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Orders_OrdersId",
                table: "Menus",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
