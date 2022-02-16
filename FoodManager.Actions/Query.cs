using FoodManager.DataAccess.Context;

namespace FoodManager.Actions
{
    public abstract class Query
    {
        protected EntityContext Context { get; set; }

        public void SetEntityContext(EntityContext context)
        {
            Context = context;
        }
    }

    public abstract class Query<TResult> : Query 
        where TResult : class
    {
        public virtual IEnumerable<TResult> Execute()
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<TResult>> ExecuteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
