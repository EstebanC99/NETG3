using System.Linq;

namespace ResourceAccess.Repository
{
    public interface IEntityLoaderRepository : IDataAccessBase
    {
        Entity GetByID<Entity>(int ID) where Entity : class;

        IQueryable<Entity> Query<Entity>() where Entity : class;
    }
}