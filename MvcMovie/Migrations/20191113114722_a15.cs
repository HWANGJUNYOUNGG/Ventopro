using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Productp_code",
                table: "Sell",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sell_Productp_code",
                table: "Sell",
                column: "Productp_code");

            migrationBuilder.AddForeignKey(
                name: "FK_Sell_Product_Productp_code",
                table: "Sell",
                column: "Productp_code",
                principalTable: "Product",
                principalColumn: "p_code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sell_Product_Productp_code",
                table: "Sell");

            migrationBuilder.DropIndex(
                name: "IX_Sell_Productp_code",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "Productp_code",
                table: "Sell");

            migrationBuilder.AddColumn<string>(
                name: "ProductForeignKey",
                table: "Sell",
                type: "nvarchar(450)",
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
    }
}
