using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.FooterDb
{
    public partial class Footer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Footer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooterLeftTitle = table.Column<string>(maxLength: 90, nullable: true),
                    FooterMidTitle = table.Column<string>(maxLength: 90, nullable: true),
                    FooterRightTitle = table.Column<string>(maxLength: 90, nullable: true),
                    FooterLeftContent = table.Column<string>(maxLength: 300, nullable: true),
                    FooterMidContent = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footer", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Footer");
        }
    }
}
