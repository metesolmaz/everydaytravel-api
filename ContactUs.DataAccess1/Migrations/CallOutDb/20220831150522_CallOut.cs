using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.CallOutDb
{
    public partial class CallOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallOut",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconP = table.Column<string>(maxLength: 30, nullable: true),
                    IconM = table.Column<string>(maxLength: 30, nullable: true),
                    Image = table.Column<string>(maxLength: 200, nullable: true),
                    CallOutTopText = table.Column<string>(maxLength: 200, nullable: true),
                    CallOutBottomText = table.Column<string>(maxLength: 200, nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallOut", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CallOut");
        }
    }
}
