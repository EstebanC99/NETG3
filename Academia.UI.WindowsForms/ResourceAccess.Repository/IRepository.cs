using System.Collections.Generic;

namespace ResourceAccess.Repository
{
    public interface IRepository<TEntity> : IDataAccessBase
        where TEntity : class
    {
        TEntity GetByID(int ID);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Remove(TEntity entity);
    }
}