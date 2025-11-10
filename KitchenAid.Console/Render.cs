using System;
using System.Collections.Generic;
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
			string prompt = PromptBuilder(appData);

			//clear cosole and render new display
			System.Console.Clear();
			System.Console.WriteLine(title + prompt);

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

		private static string PromptBuilder(AppData appData)
		{
			string p1 = (appData.table == Tables.notSet) ? "table" : "action";
			string p2 = (appData.table != Tables.notSet) ?  "\"back\" to return, " : string.Empty;
			var options = (appData.table == Tables.notSet) ? Enum.GetNames(typeof(Tables)) : Enum.GetNames(typeof(tableAction));

			string result = $"Choose a {p1} from -\n\r";
			
			//start rom 1 to avoid notSet
			for(int i = 1; i < options.Count(); i ++)
			{ result += $"{i}.{options[i]} "; }			


			result += $"\n\r\n\ror type {p2}\"exit\" to close app";
			
			result +="\n\r\n\rInput-";

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

	}
}
