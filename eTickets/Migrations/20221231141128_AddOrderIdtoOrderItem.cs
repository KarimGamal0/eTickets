using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class AddOrderIdtoOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_Orders_orderId",
                table: "orderItems");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "orderItems",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_orderItems_orderId",
                table: "orderItems",
                newName: "IX_orderItems_OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "orderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_Orders_OrderId",
                table: "orderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_Orders_OrderId",
                table: "orderItems");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "orderItems",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_orderItems_OrderId",
                table: "orderItems",
                newName: "IX_orderItems_orderId");

            migrationBuilder.AlterColumn<int>(
                name: "orderId",
                table: "orderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_Orders_orderId",
                table: "orderItems",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
