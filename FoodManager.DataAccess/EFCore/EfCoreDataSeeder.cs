using FoodManager.Model;

namespace FoodManager.DataAccess.EFCore
{
    public class EfCoreDataSeeder : IDataSeeder
    {
        private readonly FoodManagerContext context;

        public EfCoreDataSeeder(FoodManagerContext context)
        {
            this.context = context;
        }

        public void SeedData()
        {
            if (context.Recipes.Any())
            {
                return;
            }

            var defaultRecipes = new[]
            {
                new Recipe
                {
                    Name = "Bolognese",
                    Steps = new[] { new Step { Body = "Cook the pasta"}},
                    Ingredients = new[] { new Ingredient { Name = "Pasta", Quantity = 200, QuantityUom = UnitOfMeasurement.gram }}
                }
            };

            context.Recipes.AddRange(defaultRecipes);
            context.SaveChanges();
        }
    }
}
