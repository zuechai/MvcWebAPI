using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetapi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIngListName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngrdientsLists_Ingredients_IngredientId",
                table: "IngrdientsLists");

            migrationBuilder.DropForeignKey(
                name: "FK_IngrdientsLists_Recipes_RecipeId",
                table: "IngrdientsLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngrdientsLists",
                table: "IngrdientsLists");

            migrationBuilder.RenameTable(
                name: "IngrdientsLists",
                newName: "IngredientsLists");

            migrationBuilder.RenameIndex(
                name: "IX_IngrdientsLists_RecipeId",
                table: "IngredientsLists",
                newName: "IX_IngredientsLists_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_IngrdientsLists_IngredientId",
                table: "IngredientsLists",
                newName: "IX_IngredientsLists_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientsLists",
                table: "IngredientsLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientsLists_Ingredients_IngredientId",
                table: "IngredientsLists",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientsLists_Recipes_RecipeId",
                table: "IngredientsLists",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientsLists_Ingredients_IngredientId",
                table: "IngredientsLists");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientsLists_Recipes_RecipeId",
                table: "IngredientsLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientsLists",
                table: "IngredientsLists");

            migrationBuilder.RenameTable(
                name: "IngredientsLists",
                newName: "IngrdientsLists");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientsLists_RecipeId",
                table: "IngrdientsLists",
                newName: "IX_IngrdientsLists_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientsLists_IngredientId",
                table: "IngrdientsLists",
                newName: "IX_IngrdientsLists_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngrdientsLists",
                table: "IngrdientsLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngrdientsLists_Ingredients_IngredientId",
                table: "IngrdientsLists",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngrdientsLists_Recipes_RecipeId",
                table: "IngrdientsLists",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
