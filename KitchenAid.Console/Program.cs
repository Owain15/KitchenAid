
using KitchenAid;
using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseSqlite("Data Source=myapp.db");

using (var context = new AppDbContext(optionsBuilder.Options))
{
	// Ensure database is created
	context.Database.EnsureCreated();

	// Use your context
	var items = context.Dishes.ToList();
}



Console.WriteLine("Hello All!");


Console.ReadLine();