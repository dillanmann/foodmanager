using Microsoft.AspNetCore.Mvc;
using FoodManager.Model;
using FoodManager.DataAccess.Context;
using FoodManager.Actions.Actions.Queries;
using FoodManager.Actions.Actions.Commands;

namespace FoodManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : BaseController
    {
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(ILogger<RecipeController> logger, EntityContext entityContext)
            : base(entityContext)
        {
            _logger = logger;
        }

        [HttpGet(Name = nameof(GetRecipe))]
        public async Task<IEnumerable<Recipe>> GetRecipe([FromQuery] AllRecipesQuery query) => await query.ExecuteAsync();

        [HttpPost(Name = nameof(CreateRecipe))]
        public async Task CreateRecipe([FromQuery] AddRecipeCommand command) => await command.ExecuteAsync();
    }
}