using KitchenAid.Table;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAid.Console
{
	internal static class Render
	{
		private static string rootTitle = "  KitchenAid-ConsoleApp";
		public static void Display(AppData appData)
		{
			string title = TitleBuilder(appData);
			string? data = DataBuilder(appData);
			string prompt = PromptBuilder(appData);

			//clear cosole and render new display
			System.Console.Clear();

			System.Console.WriteLine(title);
			if(data != null)
			{System.Console.WriteLine(data); }
			System.Console.WriteLine(prompt);

		}

		

		private static string TitleBuilder(AppData appData)
		{
			string result = rootTitle;

			if(appData.table != Tables.notSet)
			{ 
				result += "-" + appData.table.ToString();

				if (appData.action != tableAction.notSet)
				{
					result += "-" + appData.action.ToString();
				}
			}

			return result  + "\n\r\n\r"; 
		}

		private static string? DataBuilder(AppData appData)
		{
			if(appData.table == Tables.notSet || appData.action == tableAction.notSet)
			{ return null; }


			string result = string.Empty;
			Recipe input = new Recipe("Test");
			input.Id = 015;
			input.Instructions = "Cook!";

			result = Render.Recipe(input);
			return result;

		}

		private static string PromptBuilder(AppData appData)
		{

			string result = string.Empty;

			if (appData.table == Tables.notSet || appData.action == tableAction.notSet)
			{
				string p1 = (appData.table == Tables.notSet) ? "table" : "action";
				string p2 = (appData.table != Tables.notSet) ? "\"back\" to return, " : string.Empty;
				var options = (appData.table == Tables.notSet) ? Enum.GetNames(typeof(Tables)) : Enum.GetNames(typeof(tableAction));

				result = $"Choose a {p1} from -\n\r";

				//start rom 1 to avoid notSet
				for (int i = 1; i < options.Count(); i++)
				{ result += $"{i}.{options[i]} "; }


				result += $"\n\r\n\ror type {p2}\"exit\" to close app";

				result += "\n\r\n\rInput-";

				return result;
			}
			else if (appData.table == Tables.recipe || appData.action == tableAction.view)
			{
				result = "input a \"Name\" or \"Id\" to view a recipe\n\r\"back\" to return, or \"exit\" to close app\n\r\n\rInput :";

			}
			else {result = " no prompt set..."; };

			return result;
			
		}



		private static string Recipe(Recipe input)
		{

			string result = string.Empty;

			string ingredientList = string.Empty; 
			foreach(var ingredient in input.SubRecipes)
			{ ingredientList += ingredient.ChildRecipe.Name + " - " + ingredient.UnitsAndMeasures.Measurement.ToString() + " " + ingredient.UnitsAndMeasures.Unit.ToString() + " , "; }

			string finalMeasure = (input.FinalMeasure != null) ? input.FinalMeasure.Measurement.ToString() + " " + input.FinalMeasure.Unit.ToString() : string.Empty;
				

			result = $"Name : {input.Name}\n\r\n\rId : {input.Id}\n\r\n\rFinal Measure : {finalMeasure}\n\r\n\rIngredients :\n\r{ingredientList}\n\r\n\rInstructions :\n\r{input.Instructions}\n\r\n\r";

			return result;
		}



		public static void MainDisplay()
		{
			System.Console.Clear();

			System.Console.WriteLine("  KitchenAid-ConsoleApp");


			System.Console.WriteLine("\n\rChoose a table?\n\rFrom-");
			//print all table options
			System.Console.WriteLine("1.recipe");


			System.Console.WriteLine("\n\ror type exit to close app.\n\r\n\rInput-");

		}

		public static void TestDisplay()
		{
			List<Recipe> data = DataAccess.iMyDb.TestCode();
			
			System.Console.Clear();

			System.Console.WriteLine("  KitchenAid-ConsoleApp-TestDisplay\n\r\n\r");

			System.Console.WriteLine("Recipe Count : " + data.Count.ToString() + "\n\r\n\r");

			foreach (var item in data)
			{
				System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
				System.Console.WriteLine("Name: " + item.Name + "\n\rId: " + item.Id + "\n\rSubRecipe Count: " + item.SubRecipes.Count.ToString());
				System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -\n\r\n\r");
			}

			System.Console.ReadLine();

			Recipe rec = data.Where(x => x.Id == 12).First();

			//rec.Id = data.Count +1;
			//rec.Name = "Egg";
			//rec.FinalMeasure = new UnitAndMeasure();
			//rec.FinalMeasure.Measurement = 28m;
			//rec.FinalMeasure.Unit = Units.Grams; 
			//System.Console.WriteLine(Render.Recipe(rec));

			System.Console.ReadLine();

			DataAccess.iMyDb.RemoveRecipe(rec);


		}

	}
}



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
