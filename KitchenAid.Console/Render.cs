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
			string title = TitleBuilder();
			string prompt = PromptBuilder();

			//clear cosole and render new display
			System.Console.Clear();
			System.Console.WriteLine(title + prompt);

		}

		private static string TitleBuilder()
		{ return rootTitle + "\n\r"; }

		private static string PromptBuilder()
		{
			return "\n\rChoose a table from-\n\r1.recipe 2.ingredient 3.suppliers\n\r\n\ror type exit to close app.\n\r\n\rInput-";
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
