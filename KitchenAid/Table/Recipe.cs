namespace KitchenAid.Table
{
	public class Recipe
	{
		public long Id { get; set; }
		public string Name { get; set; } = "Undefined.";
		public ICollection<RecipeSubRecipe> SubRecipes { get; set; } = new List<RecipeSubRecipe>();
		public string? Instructions { get; set; }

		public UnitAndMeasure? FinalMeasure { get; set; }

		public Recipe(string name)
		{
			Name = name;
		}

		public Recipe() { }



	}

}
