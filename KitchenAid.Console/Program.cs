
using KitchenAid;
using KitchenAid.Console;
using KitchenAid.Table;
using Microsoft.EntityFrameworkCore;
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
	switch(input)
	{
		case "": { break; }
		case "exit": { appData.isRunning = false; break; }
		default: 
			{ 
				System.Console.WriteLine("\n\rinvalid input\n\rpress any key to continue");
				System.Console.ReadKey();
				break;
			}
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