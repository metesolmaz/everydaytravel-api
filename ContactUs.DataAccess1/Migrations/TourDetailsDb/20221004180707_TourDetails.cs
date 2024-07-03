using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.TourDetailsDb
{
    public partial class TourDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TourDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourHeader = table.Column<string>(maxLength: 300, nullable: true),
                    TourHeaderImage = table.Column<string>(nullable: true),
                    TourContent = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    ısPopular = table.Column<bool>(nullable: false),
                    ısVip = table.Column<bool>(nullable: false),
                    TourId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourDetails");
        }
    }
}
