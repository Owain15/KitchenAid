namespace KitchenAid.Domain.Entities
{
	public class RecipeIngredient
	{
		public long Id { get; set; }
		public long RecipeId { get; set; }
		public Recipe Recipe { get; set; }

		public long IngredientId { get; set; }
		public Ingredient Ingredient { get; set; }

		public UnitAndMeasure UnitsAndMeasures { get; set; }

	}

}
