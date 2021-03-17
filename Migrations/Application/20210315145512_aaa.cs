using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityTest.Migrations.Application
{
    public partial class aaa : Migration
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

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
