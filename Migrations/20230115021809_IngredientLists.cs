using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetapi.Migrations
{
    /// <inheritdoc />
    public partial class IngredientLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientIngredientList");

            migrationBuilder.AddColumn<string>(
                name: "Preparation",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IngredientId",
                table: "IngrdientsLists",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_IngrdientsLists_IngredientId",
                table: "IngrdientsLists",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngrdientsLists_Ingredients_IngredientId",
                table: "IngrdientsLists",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngrdientsLists_Ingredients_IngredientId",
                table: "IngrdientsLists");

            migrationBuilder.DropIndex(
                name: "IX_IngrdientsLists_IngredientId",
                table: "IngrdientsLists");

            migrationBuilder.DropColumn(
                name: "Preparation",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "IngrdientsLists");

            migrationBuilder.CreateTable(
                name: "IngredientIngredientList",
                columns: table => new
                {
                    IngredientListsId = table.Column<long>(type: "bigint", nullable: false),
                    IngredientsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientIngredientList", x => new { x.IngredientListsId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_IngredientIngredientList_IngrdientsLists_IngredientListsId",
                        column: x => x.IngredientListsId,
                        principalTable: "IngrdientsLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientIngredientList_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientIngredientList_IngredientsId",
                table: "IngredientIngredientList",
                column: "IngredientsId");
        }
    }
}
