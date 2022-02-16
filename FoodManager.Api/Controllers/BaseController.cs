using FoodManager.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace FoodManager.Api.Controllers
{
    public abstract class BaseController : Controller
    {
        public EntityContext EntityContext { get; protected set; }

        protected BaseController(EntityContext entityContext)
        {
            EntityContext = entityContext;
        }
    }
}
