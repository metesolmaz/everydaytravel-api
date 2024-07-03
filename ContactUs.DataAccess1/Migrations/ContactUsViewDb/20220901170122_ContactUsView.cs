using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactUs.DataAccess1.Migrations.ContactUsViewDb
{
    public partial class ContactUsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUsView",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainHeader = table.Column<string>(maxLength: 40, nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    AdressHeader = table.Column<string>(maxLength: 50, nullable: true),
                    AdressDescription = table.Column<string>(nullable: true),
                    ContactHeader = table.Column<string>(maxLength: 90, nullable: true),
                    ContactDescriptionJson = table.Column<string>(nullable: true),
                    InputNameText = table.Column<string>(maxLength: 80, nullable: true),
                    InputMailText = table.Column<string>(maxLength: 120, nullable: true),
                    InputPhoneText = table.Column<string>(maxLength: 120, nullable: true),
                    InputMessageText = table.Column<string>(maxLength: 120, nullable: true),
                    ButtonText = table.Column<string>(maxLength: 50, nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsView", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUsView");
        }
    }
}
