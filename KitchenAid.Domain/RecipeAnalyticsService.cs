using KitchenAid.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

public class RecipeAnalyticsService
{

    public RecipeAnalyticsService()
    {

    }

    public List<RecipeSubRecipe> GetNecessaryIngredients(List<Recipe> recipes)
    {
        var baseRecipeMap = new Dictionary<long, RecipeSubRecipe>();
        
        foreach (var recipe in recipes)
        {
            CollectBaseRecipesRecursive(recipe, new HashSet<long>(), baseRecipeMap, null);
        }

        return baseRecipeMap.Values.ToList();
    }

    private void CollectBaseRecipesRecursive(Recipe recipe, HashSet<long> currentPath, Dictionary<long, RecipeSubRecipe> baseRecipeMap, RecipeSubRecipe parentSubRecipe)
    {
        if (currentPath.Contains(recipe.Id))
        {
            throw new System.InvalidOperationException($"Cyclic dependency detected for recipe ID {recipe.Id}");
        }

        currentPath.Add(recipe.Id);

        // If recipe has no sub-recipes, it's a base recipe
        if (recipe.SubRecipes == null || recipe.SubRecipes.Count == 0)
        {
            // For base recipes, use the measurement from the parent SubRecipe
            var measurement = recipe.FinalMeasure;
            
            if (!baseRecipeMap.ContainsKey(recipe.Id))
            {
                baseRecipeMap[recipe.Id] = new RecipeSubRecipe
                {
                    ChildRecipe = recipe,
                    ChildRecipeId = recipe.Id,
                    UnitsAndMeasures = new UnitAndMeasure { Measurement = measurement.Measurement, Unit = measurement.Unit }
                };
            }
            else
            {
                // Aggregate measurements if the same base recipe appears multiple times
                var existing = baseRecipeMap[recipe.Id];
                if (existing.UnitsAndMeasures.Unit == measurement.Unit)
                {
                    existing.UnitsAndMeasures.Measurement += measurement.Measurement;
                }
            }
        }
        else
        {
            // Otherwise, recurse into all sub-recipes with their measurements
            foreach (var subRecipe in recipe.SubRecipes)
            {
                CollectBaseRecipesRecursive(subRecipe.ChildRecipe, currentPath, baseRecipeMap, subRecipe);
            }
        }

        // Remove from current path when backtracking
        currentPath.Remove(recipe.Id);
    }

}