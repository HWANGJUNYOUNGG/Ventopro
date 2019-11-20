using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Productp_code",
                table: "Sell",
                type: "nvarchar(450)",
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
    }
}
