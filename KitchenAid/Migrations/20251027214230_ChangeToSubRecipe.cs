using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitchenAid.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToSubRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeRecipe");

            migrationBuilder.CreateTable(
                name: "RecipeSubRecipe",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentRecipeId = table.Column<long>(type: "INTEGER", nullable: false),
                    ChildRecipeId = table.Column<long>(type: "INTEGER", nullable: false),
                    UnitsAndMeasures_Measurement = table.Column<decimal>(type: "TEXT", nullable: false),
                    UnitsAndMeasures_Unit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSubRecipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeSubRecipe_Recipes_ChildRecipeId",
                        column: x => x.ChildRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeSubRecipe_Recipes_ParentRecipeId",
                        column: x => x.ParentRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSubRecipe_ChildRecipeId",
                table: "RecipeSubRecipe",
                column: "ChildRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSubRecipe_ParentRecipeId",
                table: "RecipeSubRecipe",
                column: "ParentRecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeSubRecipe");

            migrationBuilder.CreateTable(
                name: "RecipeRecipe",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChildRecipeId = table.Column<long>(type: "INTEGER", nullable: false),
                    ParentRecipeId = table.Column<long>(type: "INTEGER", nullable: false),
                    UnitsAndMeasures_Measurement = table.Column<decimal>(type: "TEXT", nullable: false),
                    UnitsAndMeasures_Unit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeRecipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeRecipe_Recipes_ChildRecipeId",
                        column: x => x.ChildRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeRecipe_Recipes_ParentRecipeId",
                        column: x => x.ParentRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeRecipe_ChildRecipeId",
                table: "RecipeRecipe",
                column: "ChildRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeRecipe_ParentRecipeId",
                table: "RecipeRecipe",
                column: "ParentRecipeId");
        }
    }
}
