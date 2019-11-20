using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class b130 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sell_Product_p_code",
                table: "Sell");

            migrationBuilder.DropIndex(
                name: "IX_Sell_p_code",
                table: "Sell");

            migrationBuilder.AlterColumn<string>(
                name: "p_code",
                table: "Sell",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p_name",
                table: "Sell",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "p_name",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Product_p_name",
                table: "Product",
                column: "p_name");

            migrationBuilder.CreateIndex(
                name: "IX_Sell_p_name",
                table: "Sell",
                column: "p_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Sell_Product_p_name",
                table: "Sell",
                column: "p_name",
                principalTable: "Product",
                principalColumn: "p_name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sell_Product_p_name",
                table: "Sell");

            migrationBuilder.DropIndex(
                name: "IX_Sell_p_name",
                table: "Sell");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Product_p_name",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "p_name",
                table: "Sell");

            migrationBuilder.AlterColumn<string>(
                name: "p_code",
                table: "Sell",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "p_name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Sell_p_code",
                table: "Sell",
                column: "p_code");

            migrationBuilder.AddForeignKey(
                name: "FK_Sell_Product_p_code",
                table: "Sell",
                column: "p_code",
                principalTable: "Product",
                principalColumn: "p_code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
