using EntityFramework.DbContextScope.Interfaces;
using System.Linq;

namespace ResourceAccess.Repository
{
    public class EntityLoaderRepository : DataAccessBase<AcademiaDbContext>, IEntityLoaderRepository
    {
        public EntityLoaderRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        public Entity GetByID<Entity>(int ID)
            where Entity : class
        {
            return this.DbContext.Set<Entity>().Find(ID);
        }

        public IQueryable<Entity> Query<Entity>()
            where Entity : class
        {
            return this.DbContext.Set<Entity>().AsQueryable();
        }
    }
}
