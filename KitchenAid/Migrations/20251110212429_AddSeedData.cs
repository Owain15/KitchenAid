using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KitchenAid.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeSubRecipe_Recipes_ChildRecipeId",
                table: "RecipeSubRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeSubRecipe_Recipes_ParentRecipeId",
                table: "RecipeSubRecipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeSubRecipe",
                table: "RecipeSubRecipe");

            migrationBuilder.RenameTable(
                name: "RecipeSubRecipe",
                newName: "SubRecipes");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeSubRecipe_ParentRecipeId",
                table: "SubRecipes",
                newName: "IX_SubRecipes_ParentRecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeSubRecipe_ChildRecipeId",
                table: "SubRecipes",
                newName: "IX_SubRecipes_ChildRecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubRecipes",
                table: "SubRecipes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Instructions", "Name", "FinalMeasure_Measurement", "FinalMeasure_Unit" },
                values: new object[,]
                {
                    { 1L, null, "Bread", 100m, 0 },
                    { 2L, null, "Oil", 100m, 0 },
                    { 3L, null, "Garlic", 100m, 0 },
                    { 4L, null, "Parmesan", 100m, 0 },
                    { 5L, null, "Anchovy", 100m, 0 },
                    { 6L, null, "Mayonnaise", 100m, 0 },
                    { 7L, null, "Salad Leaf", 100m, 0 },
                    { 8L, null, "Crouton", 100m, 0 },
                    { 9L, null, "Caesar Dressing", 300m, 1 },
                    { 10L, null, "Caesar Salad", 250m, 0 }
                });

            migrationBuilder.InsertData(
                table: "SubRecipes",
                columns: new[] { "Id", "ChildRecipeId", "ParentRecipeId", "UnitsAndMeasures_Measurement", "UnitsAndMeasures_Unit" },
                values: new object[,]
                {
                    { 1L, 1L, 8L, 90m, 0 },
                    { 2L, 3L, 8L, 4m, 0 },
                    { 3L, 2L, 8L, 30m, 1 },
                    { 4L, 3L, 9L, 8m, 0 },
                    { 5L, 4L, 9L, 60m, 0 },
                    { 6L, 5L, 9L, 10m, 0 },
                    { 7L, 6L, 9L, 280m, 1 },
                    { 8L, 7L, 10L, 150m, 0 },
                    { 9L, 8L, 10L, 30m, 0 },
                    { 10L, 9L, 10L, 70m, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SubRecipes_Recipes_ChildRecipeId",
                table: "SubRecipes",
                column: "ChildRecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubRecipes_Recipes_ParentRecipeId",
                table: "SubRecipes",
                column: "ParentRecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubRecipes_Recipes_ChildRecipeId",
                table: "SubRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_SubRecipes_Recipes_ParentRecipeId",
                table: "SubRecipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubRecipes",
                table: "SubRecipes");

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "SubRecipes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.RenameTable(
                name: "SubRecipes",
                newName: "RecipeSubRecipe");

            migrationBuilder.RenameIndex(
                name: "IX_SubRecipes_ParentRecipeId",
                table: "RecipeSubRecipe",
                newName: "IX_RecipeSubRecipe_ParentRecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_SubRecipes_ChildRecipeId",
                table: "RecipeSubRecipe",
                newName: "IX_RecipeSubRecipe_ChildRecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeSubRecipe",
                table: "RecipeSubRecipe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeSubRecipe_Recipes_ChildRecipeId",
                table: "RecipeSubRecipe",
                column: "ChildRecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeSubRecipe_Recipes_ParentRecipeId",
                table: "RecipeSubRecipe",
                column: "ParentRecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
