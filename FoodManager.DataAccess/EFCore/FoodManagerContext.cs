using FoodManager.Model;
using Microsoft.EntityFrameworkCore;

namespace FoodManager.DataAccess.EFCore
{
    public class FoodManagerContext : DbContext
    {
        public FoodManagerContext(DbContextOptions<FoodManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
