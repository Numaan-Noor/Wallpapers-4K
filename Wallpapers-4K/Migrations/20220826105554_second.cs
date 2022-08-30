using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallpapers_4K.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_wallpapers_WallpaperId",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_WallpaperId",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "WallpaperId",
                table: "categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "wallpapers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryNavigationId",
                table: "wallpapers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wallpapers_CategoryNavigationId",
                table: "wallpapers",
                column: "CategoryNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_wallpapers_categories_CategoryNavigationId",
                table: "wallpapers",
                column: "CategoryNavigationId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wallpapers_categories_CategoryNavigationId",
                table: "wallpapers");

            migrationBuilder.DropIndex(
                name: "IX_wallpapers_CategoryNavigationId",
                table: "wallpapers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "wallpapers");

            migrationBuilder.DropColumn(
                name: "CategoryNavigationId",
                table: "wallpapers");

            migrationBuilder.AddColumn<int>(
                name: "WallpaperId",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_WallpaperId",
                table: "categories",
                column: "WallpaperId");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_wallpapers_WallpaperId",
                table: "categories",
                column: "WallpaperId",
                principalTable: "wallpapers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
