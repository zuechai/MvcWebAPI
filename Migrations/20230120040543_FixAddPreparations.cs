using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetapi.Migrations
{
    /// <inheritdoc />
    public partial class FixAddPreparations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientsLists_Ingredients_IngredientId",
                table: "IngredientsLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Methods_Recipes_RecipeId",
                table: "Methods");

            migrationBuilder.DropIndex(
                name: "IX_Methods_RecipeId",
                table: "Methods");

            migrationBuilder.DropIndex(
                name: "IX_IngredientsLists_IngredientId",
                table: "IngredientsLists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Methods_RecipeId",
                table: "Methods",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsLists_IngredientId",
                table: "IngredientsLists",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientsLists_Ingredients_IngredientId",
                table: "IngredientsLists",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Methods_Recipes_RecipeId",
                table: "Methods",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
