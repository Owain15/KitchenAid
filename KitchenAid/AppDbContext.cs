
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KitchenAid
{
	public class AppDbContext : DbContext
	{


		public AppDbContext(DbContextOptions<AppDbContext> options)
	  : base(options)
		{
		}


		public DbSet<Recipe> Recipes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.Entity<Recipe>()
			//	.OwnsOne(i => i.UnitsAndMeasures);

			modelBuilder.Entity<Recipe>()
			.OwnsOne(i => i.FinalMeasure);

			modelBuilder.Entity<RecipeIngredient>()
			.OwnsOne(i => i.UnitsAndMeasures);

			modelBuilder.Entity<RecipeSubRecipe>()
			.OwnsOne(i => i.UnitsAndMeasures);


		}
	}


	public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
	{
		public AppDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlite("Data Source=myapp.db");

			return new AppDbContext(optionsBuilder.Options);
		}
	}
}

