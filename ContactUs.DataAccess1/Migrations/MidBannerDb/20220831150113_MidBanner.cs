using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.MidBannerDb
{
    public partial class MidBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MidBanner",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(maxLength: 30, nullable: true),
                    Icons = table.Column<string>(maxLength: 40, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Logo = table.Column<string>(maxLength: 150, nullable: true),
                    BannerText = table.Column<string>(maxLength: 70, nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidBanner", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MidBanner");
        }
    }
}
