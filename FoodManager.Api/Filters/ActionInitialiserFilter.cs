using Microsoft.AspNetCore.Mvc.Filters;

namespace FoodManager.Api.Filters
{
    public class ActionInitialiserFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.IsActionAQuery())
            {
                context.Query().SetEntityContext(context.Controller().EntityContext);
            }
            else if (context.IsActionACommand())
            {
                context.Command().SetEntityContext(context.Controller().EntityContext);
            }
        }
    }
}
