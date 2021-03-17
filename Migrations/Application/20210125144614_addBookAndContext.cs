using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityTest.Migrations.Application
{
    public partial class addBookAndContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
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
            migrationBuilder.DropTable(
                name: "Books");
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SWIFTCode",
                table: "Books");
        }
    }
}
