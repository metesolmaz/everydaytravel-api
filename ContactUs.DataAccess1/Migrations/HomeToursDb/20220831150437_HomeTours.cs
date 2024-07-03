using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.HomeToursDb
{
    public partial class HomeTours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeTours",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToursHeader = table.Column<string>(maxLength: 200, nullable: true),
                    ToursText = table.Column<string>(maxLength: 250, nullable: true),
                    ToursButtonText = table.Column<string>(maxLength: 120, nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTours", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeTours");
        }
    }
}
