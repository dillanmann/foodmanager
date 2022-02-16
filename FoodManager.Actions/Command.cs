using FoodManager.DataAccess.Context;

namespace FoodManager.Actions
{
    public abstract class Command
    {
        protected EntityContext EntityContext { get; set; }

        public void SetEntityContext(EntityContext context)
        {
            EntityContext = context;
        }

        public virtual void Execute()
        {
            throw new NotImplementedException();
        }

        public virtual Task ExecuteAsync()
        {
            throw new NotImplementedException();
        }
    }

    /*abstract class Command<TTarget> : Command
        where TTarget : class
    {
        protected virtual TTarget Target { get; set; }

        public void SetTarget(TTarget target)
        {
            Target = target;
        }
    }*/
}
