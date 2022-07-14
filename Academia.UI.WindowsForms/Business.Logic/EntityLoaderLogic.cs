using Business.Logic.Interfaces;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository;
using System.Linq;

namespace Business.Logic
{
    public class EntityLoaderLogic : LogicBase<IEntityLoaderRepository>, IEntityLoaderLogicService
    {
        public EntityLoaderLogic(IDbContextScopeFactory dbContextScopeFactory, IEntityLoaderRepository repository)
            : base(dbContextScopeFactory, repository)
        {
        }

        public Entity GetByID<Entity>(int ID)
            where Entity : class
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetByID<Entity>(ID);
            }
        }

        public IQueryable<Entity> Query<Entity>()
            where Entity : class
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.Query<Entity>();
            }
        }
    }
}
