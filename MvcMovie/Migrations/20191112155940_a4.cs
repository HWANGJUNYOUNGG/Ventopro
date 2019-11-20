using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Sell",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Productp_code",
                table: "Sell",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "p_code",
                table: "Sell",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "p_code",
                table: "Sell");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Sell",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
