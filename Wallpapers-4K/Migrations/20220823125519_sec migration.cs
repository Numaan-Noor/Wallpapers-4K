using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallpapers_4K.Migrations
{
    public partial class secmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "wallpapers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "wallpapers");
        }
    }
}
