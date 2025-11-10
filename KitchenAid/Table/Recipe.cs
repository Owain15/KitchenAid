namespace KitchenAid.Table
{
	public class Recipe
	{
		public long Id { get; set; }
		public string Name { get; set; } = "Undefined.";
		public ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
		//public ICollection<UnitAndMeasure> UnitsAndMeasures { get; set; } = new List<UnitAndMeasure>();
		public string? Instructions { get; set; }

		public UnitAndMeasure? FinalMeasure;

		public Recipe(string name)
		{
			Name = name;
		}

		private Recipe() { }



	}

}
