
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


		public DbSet<Dish> Dishes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
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

