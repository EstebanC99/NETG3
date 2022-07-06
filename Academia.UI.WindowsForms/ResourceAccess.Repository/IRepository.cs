using Business.Entities;
using System.Collections.Generic;

namespace ResourceAccess.Repository
{
    public interface IRepository<TEntity> : IDataAccessBase
        where TEntity : BusinessEntity
    {
        TEntity GetByID(int ID);

        List<TEntity> GetAll();
    }
}