using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.AboutUsDb
{
    public partial class AboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainHeader = table.Column<string>(maxLength: 50, nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    TopImageLeft = table.Column<string>(nullable: true),
                    TopImageRight = table.Column<string>(nullable: true),
                    TopContentHeader = table.Column<string>(maxLength: 150, nullable: true),
                    TopContentDescription = table.Column<string>(maxLength: 300, nullable: true),
                    TopContentJson = table.Column<string>(nullable: true),
                    MidContentJson = table.Column<string>(nullable: true),
                    MidContentImage = table.Column<string>(nullable: true),
                    BottomHeader = table.Column<string>(maxLength: 200, nullable: true),
                    BottomContent = table.Column<string>(maxLength: 200, nullable: true),
                    BottomContentImage = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");
        }
    }
}
