using Business.Entities;
using ResourceAccess.Repository;

namespace Business.Logic
{
    public abstract class LogicBase<TEntity, TRepository> : ILogicBase
        where TEntity : BusinessEntity
        where TRepository : IRepository<TEntity>
    {
        protected TEntity Entity { get; set; }

        protected TRepository Repository { get; set; }

        public LogicBase(TEntity entity, TRepository repository)
        {
            this.Entity = entity;
            this.Repository = repository;
        }

    }
}
