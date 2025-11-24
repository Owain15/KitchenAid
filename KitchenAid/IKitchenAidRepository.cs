using KitchenAid.Table;

namespace KitchenAid.DataAccess
{
    public interface IKitchenAidRepository
    {
        public IQueryable<Recipe> TestCode();
        public void UpdateRecipe(Recipe entity);
        public Recipe GetRecipe();
        public IQueryable<string> GetAllRecipeNames();
        public void AddNewRecipe(Recipe entity);
        public void RemoveRecipe(Recipe entity);
    }
}
