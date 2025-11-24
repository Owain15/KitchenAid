using KitchenAid.Domain.Entities;

namespace KitchenAid.Tests
{
    public class RecipeAnalyticsServiceTests
    {
        [Fact]
        public void GetNecessaryIngredients_WithCaesarSalad_ReturnsAllBaseRecipes()
        {
            // Arrange
            var service = new RecipeAnalyticsService();

            // Build the recipe hierarchy matching the seed data:
            // Caesar Salad (10) -> Salad Leaf (7), Crouton (8), Caesar Dressing (9)
            // Crouton (8) -> Bread (1), Garlic (3), Oil (2)
            // Caesar Dressing (9) -> Garlic (3), Parmesan (4), Anchovy (5), Mayonnaise (6)

            var bread = new Recipe { Id = 1, Name = "Bread", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };
            var oil = new Recipe { Id = 2, Name = "Oil", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };
            var garlic = new Recipe { Id = 3, Name = "Garlic", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };
            var parmesan = new Recipe { Id = 4, Name = "Parmesan", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };
            var anchovy = new Recipe { Id = 5, Name = "Anchovy", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };
            var mayonnaise = new Recipe { Id = 6, Name = "Mayonnaise", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };
            var saladLeaf = new Recipe { Id = 7, Name = "Salad Leaf", SubRecipes = [], FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } };

            var crouton = new Recipe
            {
                Id = 8,
                Name = "Crouton",
                SubRecipes =
                [
                    new RecipeSubRecipe { Id = 1, ChildRecipe = bread, ParentRecipeId = 8, ChildRecipeId = 1, UnitsAndMeasures = new UnitAndMeasure { Measurement = 90m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 2, ChildRecipe = garlic, ParentRecipeId = 8, ChildRecipeId = 3, UnitsAndMeasures = new UnitAndMeasure { Measurement = 4m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 3, ChildRecipe = oil, ParentRecipeId = 8, ChildRecipeId = 2, UnitsAndMeasures = new UnitAndMeasure { Measurement = 30m, Unit = Units.Millilitres } }
                ]
            };

            var caesarDressing = new Recipe
            {
                Id = 9,
                Name = "Caesar Dressing",
                SubRecipes =
                [
                    new RecipeSubRecipe { Id = 4, ChildRecipe = garlic, ParentRecipeId = 9, ChildRecipeId = 3, UnitsAndMeasures = new UnitAndMeasure { Measurement = 8m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 5, ChildRecipe = parmesan, ParentRecipeId = 9, ChildRecipeId = 4, UnitsAndMeasures = new UnitAndMeasure { Measurement = 60m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 6, ChildRecipe = anchovy, ParentRecipeId = 9, ChildRecipeId = 5, UnitsAndMeasures = new UnitAndMeasure { Measurement = 10m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 7, ChildRecipe = mayonnaise, ParentRecipeId = 9, ChildRecipeId = 6, UnitsAndMeasures = new UnitAndMeasure { Measurement = 280m, Unit = Units.Millilitres } }
                ]
            };

            var caesarSalad = new Recipe
            {
                Id = 10,
                Name = "Caesar Salad",
                SubRecipes =
                [
                    new RecipeSubRecipe { Id = 8, ChildRecipe = saladLeaf, ParentRecipeId = 10, ChildRecipeId = 7, UnitsAndMeasures = new UnitAndMeasure { Measurement = 150m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 9, ChildRecipe = crouton, ParentRecipeId = 10, ChildRecipeId = 8, UnitsAndMeasures = new UnitAndMeasure { Measurement = 30m, Unit = Units.Grams } },
                    new RecipeSubRecipe { Id = 10, ChildRecipe = caesarDressing, ParentRecipeId = 10, ChildRecipeId = 9, UnitsAndMeasures = new UnitAndMeasure { Measurement = 70m, Unit = Units.Millilitres } }
                ]
            };

            // Act
            var result = service.GetNecessaryIngredients([caesarSalad]);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(7, result.Count);

            // Verify all base recipes are present
            var resultIds = result.Select(r => r.ChildRecipeId).Order().ToList();
            var expectedIds = new List<long> { 1, 2, 3, 4, 5, 6, 7 }.Order().ToList();
            Assert.Equal(expectedIds, resultIds);

            // Verify correct names and measurements from SubRecipes
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Bread" && r.UnitsAndMeasures.Measurement == 90m));
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Oil" && r.UnitsAndMeasures.Measurement == 30m));
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Garlic" && r.UnitsAndMeasures.Measurement == 12m)); // 4 + 8
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Parmesan" && r.UnitsAndMeasures.Measurement == 60m));
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Anchovy" && r.UnitsAndMeasures.Measurement == 10m));
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Mayonnaise" && r.UnitsAndMeasures.Measurement == 280m));
            Assert.Single(result.Where(r => r.ChildRecipe.Name == "Salad Leaf" && r.UnitsAndMeasures.Measurement == 150m));
        }

        [Fact]
        public void GetNecessaryIngredients_WithDuplicateBaseRecipes_AggregatesMeasurements()
        {
            // Arrange
            var service = new RecipeAnalyticsService();

            // Garlic appears in both Crouton and Caesar Dressing with same unit
            var garlic = new Recipe
            {
                Id = 3,
                Name = "Garlic",
                SubRecipes = [],
                FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams }
            };

            var crouton = new Recipe
            {
                Id = 8,
                Name = "Crouton",
                SubRecipes =
                [
                    new RecipeSubRecipe { Id = 1, ChildRecipe = garlic, ParentRecipeId = 8, ChildRecipeId = 3, UnitsAndMeasures = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } }
                ]
            };

            var caesarDressing = new Recipe
            {
                Id = 9,
                Name = "Caesar Dressing",
                SubRecipes =
                [
                    new RecipeSubRecipe { Id = 2, ChildRecipe = garlic, ParentRecipeId = 9, ChildRecipeId = 3, UnitsAndMeasures = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams } }
                ]
            };

            // Act
            var result = service.GetNecessaryIngredients([crouton, caesarDressing]);

            // Assert - should have one garlic entry with aggregated measurement
            Assert.Single(result);
            Assert.Equal(3, result[0].ChildRecipeId);
            Assert.Equal("Garlic", result[0].ChildRecipe.Name);
            Assert.Equal(200m, result[0].UnitsAndMeasures.Measurement); // 100 + 100
            Assert.Equal(Units.Grams, result[0].UnitsAndMeasures.Unit);
        }

        [Fact]
        public void GetNecessaryIngredients_WithSingleBaseRecipe_ReturnsIt()
        {
            // Arrange
            var service = new RecipeAnalyticsService();
            var bread = new Recipe
            {
                Id = 1,
                Name = "Bread",
                SubRecipes = [],
                FinalMeasure = new UnitAndMeasure { Measurement = 100m, Unit = Units.Grams }
            };

            // Act - when passing a base recipe directly, we wrap it in a list
            // Since it has no SubRecipes and no parent, the measurement will be 0
            // This test should verify that a base recipe passed directly is returned
            var result = service.GetNecessaryIngredients([bread]);

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result[0].ChildRecipeId);
            Assert.Equal("Bread", result[0].ChildRecipe.Name);
            // With no parent SubRecipe, measurement defaults to 0
            Assert.Equal(100m, result[0].UnitsAndMeasures.Measurement);
        }

        [Fact]
        public void GetNecessaryIngredients_WithCyclicDependency_ThrowsInvalidOperationException()
        {
            // Arrange
            var service = new RecipeAnalyticsService();

            var recipe1 = new Recipe { Id = 1, Name = "Recipe1", SubRecipes = [] };
            var recipe2 = new Recipe { Id = 2, Name = "Recipe2", SubRecipes = [] };

            // Create a cycle: recipe1 -> recipe2 -> recipe1
            recipe1.SubRecipes =
            [
                new RecipeSubRecipe { Id = 1, ChildRecipe = recipe2, ParentRecipeId = 1, ChildRecipeId = 2 }
            ];

            recipe2.SubRecipes =
            [
                new RecipeSubRecipe { Id = 2, ChildRecipe = recipe1, ParentRecipeId = 2, ChildRecipeId = 1 }
            ];

            // Act & Assert
            var exception = Assert.Throws<System.InvalidOperationException>(() => service.GetNecessaryIngredients([recipe1]));
            Assert.Contains("Cyclic dependency detected", exception.Message);
        }
    }
}
