
Run these commands 

dotnet ef migrations add InitialCreate --project ./KitchenAid --startup-project ./KitchenAid
dotnet ef database update --project ./KitchenAid

dotnet ef migrations add AddRecipesAndAllergies --project ./KitchenAid --startup-project ./KitchenAid.Console

dotnet ef database update  --project ./KitchenAid --startup-project ./KitchenAid.Console

dotnet ef migrations add AddSeedData --project ./KitchenAid --startup-project ./KitchenAid.Console


----

# Use Cases
AS a professional chef
I WANT TO build a menu 
SO THAT I can see the deconstructed list of ingredients needed 


----

# How to instrument the database from the calling project
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
