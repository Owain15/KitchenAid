namespace KitchenAid.Table
{
	public class RecipeSubRecipe
	{
		public long Id { get; set; }
		public long ParentRecipeId { get; set; }
		public Recipe ParentRecipe { get; set; }

		public long ChildRecipeId { get; set; }
		public Recipe ChildRecipe { get; set; }

		public UnitAndMeasure UnitsAndMeasures { get; set; }

	}

}
