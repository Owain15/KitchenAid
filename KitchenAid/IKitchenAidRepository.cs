using KitchenAid.Domain.Entities;

namespace KitchenAid.DataAccess
{
    public interface IKitchenAidRepository
    {
        public IQueryable<Recipe> GetRecipesWithSubRecipesAndFinalMeasure();
        public void UpdateRecipe(Recipe entity);
        public Recipe? GetRecipe();
        public Recipe? GetRecipe(long ID);
        public Recipe? GetRecipe(string Name);
        public IQueryable<string> GetAllRecipeNames();
        public void AddNewRecipe(Recipe entity);
        public void RemoveRecipe(Recipe entity);
        public IQueryable<RecipeSubRecipe> GetSubRecipesByRecipeId(long ID);
    }
}
