
using KitchenAid.DataAccess;
using KitchenAid.Table;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data;

namespace KitchenAid
{
    public class AppDbContext : DbContext, IKitchenAidRepository
    {


        public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
        {
        }


        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeSubRecipe> SubRecipes { get; set; }

        public void AddNewRecipe(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<string> GetAllRecipeNames() => Recipes.Select(x => x.Name);

        public Recipe GetRecipe() =>
            //  TODO: pass in an Id? 
            Recipes.FirstOrDefault();

        //   TODO: Remove by Id or entity?
        public void RemoveRecipe(Recipe entity)
        {
            throw new NotImplementedException();
        }

        //   TODO: What for? 
        public IQueryable<Recipe> TestCode()
        {
            return Recipes
               .Include(r => r.SubRecipes)
               .ThenInclude(sr => sr.ChildRecipe)
               .Include(r => r.FinalMeasure);
        }

        public void UpdateRecipe(Recipe entity)
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RecipeIngredient>()
            .OwnsOne(i => i.UnitsAndMeasures);

            modelBuilder.Entity<RecipeSubRecipe>()
                .HasOne(rr => rr.ParentRecipe)
                .WithMany(r => r.SubRecipes);

            modelBuilder.Entity<Recipe>().OwnsOne(r => r.FinalMeasure, fm =>
            {
                fm.WithOwner().HasForeignKey("RecipeId");
                fm.HasKey("RecipeId");
            });

            modelBuilder.Entity<RecipeSubRecipe>().OwnsOne(r => r.UnitsAndMeasures, um =>
            {
                um.WithOwner().HasForeignKey("RecipeSubRecipeId");
                um.HasKey("RecipeSubRecipeId");
            });



            SeedDb(modelBuilder);

        }

        private void SeedDb(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
        new Recipe { Id = 1, Name = "Bread" },
        new Recipe { Id = 2, Name = "Oil" },
        new Recipe { Id = 3, Name = "Garlic" },
        new Recipe { Id = 4, Name = "Parmesan" },
        new Recipe { Id = 5, Name = "Anchovy" },
        new Recipe { Id = 6, Name = "Mayonnaise" },
        new Recipe { Id = 7, Name = "Salad Leaf" },
        new Recipe { Id = 8, Name = "Crouton" },
        new Recipe { Id = 9, Name = "Caesar Dressing" },
        new Recipe { Id = 10, Name = "Caesar Salad" }
    );



            modelBuilder.Entity<Recipe>().OwnsOne(r => r.FinalMeasure).HasData(
                new { RecipeId = 1L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 2L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 3L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 4L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 5L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 6L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 7L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 8L, Measurement = 100m, Unit = Units.Grams },
                new { RecipeId = 9L, Measurement = 300m, Unit = Units.Millilitres },
                new { RecipeId = 10L, Measurement = 250m, Unit = Units.Grams }
            );


            modelBuilder.Entity<RecipeSubRecipe>().HasData(
    new RecipeSubRecipe { Id = 1L, ParentRecipeId = 8L, ChildRecipeId = 1L },
    new RecipeSubRecipe { Id = 2L, ParentRecipeId = 8L, ChildRecipeId = 3L },
    new RecipeSubRecipe { Id = 3L, ParentRecipeId = 8L, ChildRecipeId = 2L },
    new RecipeSubRecipe { Id = 4L, ParentRecipeId = 9L, ChildRecipeId = 3L },
    new RecipeSubRecipe { Id = 5L, ParentRecipeId = 9L, ChildRecipeId = 4L },
    new RecipeSubRecipe { Id = 6L, ParentRecipeId = 9L, ChildRecipeId = 5L },
    new RecipeSubRecipe { Id = 7L, ParentRecipeId = 9L, ChildRecipeId = 6L },
    new RecipeSubRecipe { Id = 8L, ParentRecipeId = 10L, ChildRecipeId = 7L },
    new RecipeSubRecipe { Id = 9L, ParentRecipeId = 10L, ChildRecipeId = 8L },
    new RecipeSubRecipe { Id = 10L, ParentRecipeId = 10L, ChildRecipeId = 9L }
);
            modelBuilder.Entity<RecipeSubRecipe>().OwnsOne(r => r.UnitsAndMeasures).HasData(
                new { RecipeSubRecipeId = 1L, Measurement = 90m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 2L, Measurement = 4m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 3L, Measurement = 30m, Unit = Units.Millilitres },
                new { RecipeSubRecipeId = 4L, Measurement = 8m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 5L, Measurement = 60m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 6L, Measurement = 10m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 7L, Measurement = 280m, Unit = Units.Millilitres },
                new { RecipeSubRecipeId = 8L, Measurement = 150m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 9L, Measurement = 30m, Unit = Units.Grams },
                new { RecipeSubRecipeId = 10L, Measurement = 70m, Unit = Units.Millilitres }
            );
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

