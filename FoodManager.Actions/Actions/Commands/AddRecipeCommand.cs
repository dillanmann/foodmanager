using FoodManager.Model;
using System.ComponentModel.DataAnnotations;

namespace FoodManager.Actions.Actions.Commands
{
    public class AddRecipeCommand : Command
    {
        [Required]
        public string Name { get; set; }

        public IEnumerable<Step> Steps { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public override async Task ExecuteAsync()
        {
            await EntityContext.DbContext.Recipes.AddAsync(new Recipe
            {
                Name = Name,
                Steps = Steps,
                Ingredients = Ingredients
            });

            await EntityContext.DbContext.SaveChangesAsync();
        }
    }
}
