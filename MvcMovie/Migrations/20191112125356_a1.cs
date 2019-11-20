using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Sell",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Sell",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    w_code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    w_amount = table.Column<int>(type: "int", nullable: false),
                    w_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    w_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.w_code);
                });
        }
    }
}
