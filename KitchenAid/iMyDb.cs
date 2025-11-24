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

		public static void UpdateRecipe(Recipe entity)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlite("Data Source=myapp.db");

			using (var context = new AppDbContext(optionsBuilder.Options))
			{
				// Ensure database is created
				context.Database.EnsureCreated();

				context.Recipes.Update(entity);
				context.SaveChanges();

			}
		}

		public static Recipe GetRecipie()
		{
			Recipe result = new Recipe();
			return result;
		}


		public static List<string> GetAllRecipeNames()
		{
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=myapp.db");

			List<String> result = new List<String>();

			using (var context = new AppDbContext(optionsBuilder.Options))
			{
                context.Database.EnsureCreated();

                result = context.Recipes.Select(x => x.Name).ToList();
            }

			return result;
        }


		public static void AddNewRecipe(Recipe entity)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlite("Data Source=myapp.db");

			using (var context = new AppDbContext(optionsBuilder.Options))
			{
				// Ensure database is created
				context.Database.EnsureCreated();

				context.Recipes.Add(entity);
				context.SaveChanges();

			}
		}

		public static void RemoveRecipe(Recipe entity)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlite("Data Source=myapp.db");

			using (var context = new AppDbContext(optionsBuilder.Options))
			{
				// Ensure database is created
				context.Database.EnsureCreated();

				context.Recipes.Remove(entity);
				context.SaveChanges();

			}
		}
	}
}
