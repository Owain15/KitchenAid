
using KitchenAid;
using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseSqlite("Data Source=myapp.db");

using (var context = new AppDbContext(optionsBuilder.Options))
{
	// Ensure database is created
	//context.Database.EnsureCreated();

	// Use your context
	//var items = context.Recipes.ToList();

	var foo = new Recipe("Brownie")
;
	context.Recipes.Add(foo);
	context.SaveChanges();

	var i = context.Recipes.ToList();
	Console.Write(i.First());

}



Console.WriteLine("Hello All!");


Console.ReadLine();