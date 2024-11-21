using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class mig_add_order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderDetails_OrderDetailID1",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderDetailID1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderDetailID1",
                table: "OrderDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailID1",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderDetailID1",
                table: "OrderDetails",
                column: "OrderDetailID1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderDetails_OrderDetailID1",
                table: "OrderDetails",
                column: "OrderDetailID1",
                principalTable: "OrderDetails",
                principalColumn: "OrderDetailID");
        }
    }
}
