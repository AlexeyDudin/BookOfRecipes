using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class FixRecipesPropertyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortInfo",
                table: "Recipe",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Recipe",
                newName: "DescriptionText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Recipe",
                newName: "ShortInfo");

            migrationBuilder.RenameColumn(
                name: "DescriptionText",
                table: "Recipe",
                newName: "Name");
        }
    }
}
