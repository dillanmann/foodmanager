using FoodManager.Actions;
using FoodManager.Api.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FoodManager.Api.Filters
{
    public static class FilterUtils
    {
        public static bool IsActionAQuery(this ActionExecutingContext filterContext)
            => filterContext.IsGet() && filterContext.ActionArguments.Any(actionArg => actionArg.Value is Query);

        public static bool IsActionACommand(this ActionExecutingContext filterContext)
            => filterContext.IsPost() && filterContext.ActionArguments.Any(actionArg => actionArg.Value is Command);

        public static bool IsGet(this ActionExecutingContext filterContext)
            => filterContext.HttpContext.Request.Method == "GET";

        public static bool IsPost(this ActionExecutingContext filterContext)
            => filterContext.HttpContext.Request.Method == "POST";

        public static Query Query(this ActionExecutingContext filterContext)
            => (Query)filterContext.ActionArguments.Single(actionArg => actionArg.Value is Query).Value;

        public static Command Command(this ActionExecutingContext filterContext)
            => (Command)filterContext.ActionArguments.Single(actionArg => actionArg.Value is Command).Value;

        public static BaseController Controller(this ActionExecutingContext actionContext)
            => actionContext.Controller as BaseController;
    }
}
