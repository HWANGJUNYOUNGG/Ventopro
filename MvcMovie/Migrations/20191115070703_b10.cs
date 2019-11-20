using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class b10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sell",
                table: "Sell");

            migrationBuilder.AlterColumn<string>(
                name: "p_code",
                table: "Sell",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "s_code",
                table: "Sell",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sell",
                table: "Sell",
                column: "s_code");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sell_Product_p_code",
                table: "Sell");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sell",
                table: "Sell");

            migrationBuilder.DropIndex(
                name: "IX_Sell_p_code",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "s_code",
                table: "Sell");

            migrationBuilder.AlterColumn<string>(
                name: "p_code",
                table: "Sell",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sell",
                table: "Sell",
                column: "p_code");
        }
    }
}
