using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityTest.Migrations.Application
{
    public partial class gryas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "SWIFTCode",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Books",
                nullable: true);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
