using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddPhotoAndLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LikesId",
                table: "Recipe",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PhotoId",
                table: "Recipe",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    LikeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.LikeId);
                });

            migrationBuilder.CreateTable(
                name: "ReceipePhoto",
                columns: table => new
                {
                    RecipePhotoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceipePhoto", x => x.RecipePhotoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_LikesId",
                table: "Recipe",
                column: "LikesId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_PhotoId",
                table: "Recipe",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Likes_LikesId",
                table: "Recipe",
                column: "LikesId",
                principalTable: "Likes",
                principalColumn: "LikeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_ReceipePhoto_PhotoId",
                table: "Recipe",
                column: "PhotoId",
                principalTable: "ReceipePhoto",
                principalColumn: "RecipePhotoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Likes_LikesId",
                table: "Recipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_ReceipePhoto_PhotoId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "ReceipePhoto");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_LikesId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_PhotoId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "LikesId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Recipe");
        }
    }
}
