using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityTest.Migrations.Application
{
    public partial class updateBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SWIFTCode",
                table: "Books",
                type: "nvarchar(12)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SWIFTCode",
                table: "Books");
        }
    }
}
