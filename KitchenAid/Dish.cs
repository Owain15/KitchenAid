namespace KitchenAid
{
	//public class Dish
	//{
	//	public long Id { get; set; }
	//	public string Name { get; set; }
	//	public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
	//	public string? Description { get; set; }

	//	//image?
	//	public Dish(string name)
	//	{
	//		Name = name;
	//	}

	//	private Dish() { }

		
	//}

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

	public class Ingredient
	{
		public long Id { get; set; }
		public string Name { get; set; }

		public ICollection<Allergies> Allergies { get; set;} = new List<Allergies>();

		public Ingredient(string name)
		{
			Name = name;
		}

		private Ingredient() { }


	}

	public class Allergies
	{
		public long Id { get; set; }
		public long IngredientId { get; set; }
		public long AllergyId { get; set; }

	}

	public class RecipeIngredient
	{
		public long Id { get; set; }
		public long RecipeId { get; set; }
		public Recipe Recipe { get; set; }

		public long IngredientId { get; set; }
		public Ingredient Ingredient { get; set; }

		public UnitAndMeasure UnitsAndMeasures { get; set; }

	}

	public class RecipeSubRecipe
	{
		public long Id { get; set; }
		public long ParentRecipeId { get; set; }
		public Recipe ParentRecipe { get; set; }

		public long ChildRecipeId { get; set; }
		public Recipe ChildRecipe { get; set; }

		public UnitAndMeasure UnitsAndMeasures { get; set; }

	}

	public class UnitAndMeasure
	{
		public decimal Measurement { get; set; }

		public Units Unit { get; set; }

	}

	public enum Units
	{

	}

}
