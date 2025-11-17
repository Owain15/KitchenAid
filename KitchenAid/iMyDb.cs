using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenAid.Table;
using Microsoft.EntityFrameworkCore;

namespace KitchenAid.DataAccess
{
	public static class iMyDb
	{
		public static List<Recipe> TestCode()
		{
			List<Recipe> result;

			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlite("Data Source=myapp.db");

			using (var context = new AppDbContext(optionsBuilder.Options))
			{
				// Ensure database is created
				context.Database.EnsureCreated();

				result = context.Recipes.ToList();

				for(int i = 0; i < result.Count; i++)
				{
					result[i].SubRecipes = context.SubRecipes.Where(x => x.ParentRecipeId == result[i].Id).ToList();
				}

			}


			return result;

				//var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
				//optionsBuilder.UseSqlite("Data Source=myapp.db");

				//using (var context = new AppDbContext(optionsBuilder.Options))
				//{
				//	// Ensure database is created
				//	context.Database.EnsureCreated();

				//	// Use your context
				//	var items = context.Recipes.ToList();

				//	//var foo = new Recipe("Brownie")
				//	//context.Recipes.Add(foo);
				//	//context.SaveChanges();

				//	//var i = context.Recipes.ToList();
				//	//Console.WriteLine(i.First().Name);



				//}
			}
	}
}
