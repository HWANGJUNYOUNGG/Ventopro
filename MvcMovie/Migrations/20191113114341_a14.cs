using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sell_Product_p_code1",
                table: "Sell");

            migrationBuilder.DropIndex(
                name: "IX_Sell_p_code1",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "p_code1",
                table: "Sell");

            migrationBuilder.AddColumn<string>(
                name: "ProductForeignKey",
                table: "Sell",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sell_ProductForeignKey",
                table: "Sell",
                column: "ProductForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Sell_Product_ProductForeignKey",
                table: "Sell",
                column: "ProductForeignKey",
                principalTable: "Product",
                principalColumn: "p_code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sell_Product_ProductForeignKey",
                table: "Sell");

            migrationBuilder.DropIndex(
                name: "IX_Sell_ProductForeignKey",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "ProductForeignKey",
                table: "Sell");

            migrationBuilder.AddColumn<string>(
                name: "p_code1",
                table: "Sell",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sell_p_code1",
                table: "Sell",
                column: "p_code1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sell_Product_p_code1",
                table: "Sell",
                column: "p_code1",
                principalTable: "Product",
                principalColumn: "p_code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
