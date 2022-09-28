using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class FixRecipeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Products",
                table: "Ingridient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Products",
                table: "Ingridient");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IngridientId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngridientId1 = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IngridientId);
                    table.ForeignKey(
                        name: "FK_Product_Ingridient_IngridientId1",
                        column: x => x.IngridientId1,
                        principalTable: "Ingridient",
                        principalColumn: "IngridientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_IngridientId1",
                table: "Product",
                column: "IngridientId1");
        }
    }
}
