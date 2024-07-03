using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.SliderDb
{
    public partial class Slider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: true),
                    ImagePathLeft = table.Column<string>(maxLength: 200, nullable: true),
                    SliderTopText = table.Column<string>(maxLength: 200, nullable: true),
                    SliderBottomText = table.Column<string>(maxLength: 200, nullable: true),
                    SliderBottomDescription = table.Column<string>(maxLength: 250, nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slider");
        }
    }
}
