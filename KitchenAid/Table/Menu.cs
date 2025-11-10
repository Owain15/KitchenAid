using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAid.Table
{
	public class Menu
	{
		public long Id { get; set; }
		public DateTime DateProduced {get; set;}
		public ICollection<MenuRecipe> Ingredients { get; set; } = new List<MenuRecipe>();
	}

	public class MenuRecipe
	{
		public long Id { get; set; }
		public long RecipeId { get; set; }
		public Recipe Recipe { get; set; }
		public MenuCourse Course { get; set; }


	}

	public enum MenuCourse
	{
		notSet,
		starter,
		main,
		dessert,
		side
	}

}
