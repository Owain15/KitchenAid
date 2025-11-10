
using KitchenAid;
using KitchenAid.Console;
using KitchenAid.Table;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.CompilerServices;

AppData appData = new AppData();

while (appData.isRunning)
{
	//render display
	Render.Display(appData);
	//Render.MainDisplay();

	//get command
	//Console.ReadLine();

	//Run/get command
	appData = RunCommand(appData, Console.ReadLine());	
}

Environment.Exit(0);

AppData RunCommand(AppData appData, string input)
{
	var options = (appData.table == Tables.notSet) ? Enum.GetNames(typeof(Tables)) : Enum.GetNames(typeof(tableAction));


	if (input == "")
	{  }
	else if(input == "exit")
	{
		appData.isRunning = false;
	}
	else if(input == "back" && appData.table != Tables.notSet)
	{
		appData.table = Tables.notSet;
	}
	else if(int.TryParse(input, out int output) && output < options.Count())
	{
		
		if (appData.table == Tables.notSet)
		{ appData.table = (Tables)output; }
		else if (appData.action == tableAction.notSet)
		{ appData.action = (tableAction)output; }
	}
	else if(options.Contains(input.ToLower()))
	{
		if(appData.table == Tables.notSet)
		{ appData.table = (Tables)Enum.Parse(typeof(Tables), input); }
		else if(appData.action == tableAction.notSet)
		{ appData.action = (tableAction)Enum.Parse(typeof(tableAction), input); }
	}
	else
	{
		System.Console.WriteLine("\n\rinvalid input\n\rpress any key to continue");
		System.Console.ReadKey();
	}

	return appData;
}



//Console.WriteLine("KitchenAid!");


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

//	Console.ReadLine();

//}






//Console.ReadLine();