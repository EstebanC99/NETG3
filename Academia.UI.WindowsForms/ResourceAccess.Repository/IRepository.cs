using System.Collections.Generic;

namespace ResourceAccess.Repository
{
    public interface IRepository: IDataAccessBase
    {

    }

    public interface IRepository<TEntity> : IRepository
        where TEntity : class
    {
        TEntity GetByID(int ID);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Remove(TEntity entity);
    }
}