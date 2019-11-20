using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sell",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "s_code",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "s_name",
                table: "Sell");

            migrationBuilder.AlterColumn<string>(
                name: "p_code",
                table: "Sell",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p_name",
                table: "Sell",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sell",
                table: "Sell",
                column: "p_code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sell",
                table: "Sell");

            migrationBuilder.DropColumn(
                name: "p_name",
                table: "Sell");

            migrationBuilder.AlterColumn<string>(
                name: "p_code",
                table: "Sell",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "s_code",
                table: "Sell",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "s_name",
                table: "Sell",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sell",
                table: "Sell",
                column: "s_code");
        }
    }
}
