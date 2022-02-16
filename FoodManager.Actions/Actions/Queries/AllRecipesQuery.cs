using FoodManager.Model;

namespace FoodManager.Actions.Actions.Queries
{
    public class AllRecipesQuery : Query<Recipe>
    {
        public override async Task<IEnumerable<Recipe>> ExecuteAsync() => await Task.FromResult(Context.DbContext.Recipes);
    }
}
