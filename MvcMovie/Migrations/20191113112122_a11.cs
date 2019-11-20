using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "p_name",
                table: "Sell");

            migrationBuilder.AddColumn<string>(
                name: "s_name",
                table: "Sell",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "s_name",
                table: "Sell");

            migrationBuilder.AddColumn<string>(
                name: "p_name",
                table: "Sell",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
