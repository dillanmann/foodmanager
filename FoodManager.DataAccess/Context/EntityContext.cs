using FoodManager.DataAccess.EFCore;

namespace FoodManager.DataAccess.Context
{
    public class EntityContext
    {
        public FoodManagerContext DbContext { get; set; }

        public EntityContext(FoodManagerContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
