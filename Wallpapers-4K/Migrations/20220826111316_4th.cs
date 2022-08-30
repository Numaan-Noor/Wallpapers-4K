using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallpapers_4K.Migrations
{
    public partial class _4th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_users_AdminId",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_AdminId",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_AdminId",
                table: "categories",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_users_AdminId",
                table: "categories",
                column: "AdminId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
