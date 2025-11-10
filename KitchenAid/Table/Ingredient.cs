namespace KitchenAid.Table
{
	public class Ingredient
	{
		public long Id { get; set; }
		public string Name { get; set; }

		public ICollection<Allergies> AllergieIds { get; set;} = new List<Allergies>();

		public Ingredient(string name)
		{
			Name = name;
		}

		private Ingredient() { }


	}

}
