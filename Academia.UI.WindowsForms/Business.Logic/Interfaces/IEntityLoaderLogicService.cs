using System.Linq;

namespace Business.Logic.Interfaces
{
    public interface IEntityLoaderLogicService : ILogicBase
    {
        Entity GetByID<Entity>(int ID) where Entity : class;

        IQueryable<Entity> Query<Entity>() where Entity : class;
    }
}
