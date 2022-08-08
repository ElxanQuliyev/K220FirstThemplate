using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K220FirstThemplate.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Section1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section1s", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Section1s");
        }
    }
}
