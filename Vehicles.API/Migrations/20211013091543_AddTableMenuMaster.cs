using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.API.Migrations
{
    public partial class AddTableMenuMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMaster", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuMaster");
        }
    }
}
