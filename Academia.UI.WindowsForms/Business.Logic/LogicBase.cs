using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository;

namespace Business.Logic
{
    public abstract class LogicBase<TEntity, TRepository> : ILogicBase
        where TEntity : BusinessEntity
        where TRepository : IRepository<TEntity>
    {
        protected TEntity Entity { get; set; }

        protected TRepository Repository { get; set; }

        protected IDbContextScopeFactory DbContextScopeFactory { get; private set; }

        public LogicBase(TEntity entity, TRepository repository, IDbContextScopeFactory dbContextScopeFactory)
        {
            this.Entity = entity;
            this.Repository = repository;
            this.DbContextScopeFactory = dbContextScopeFactory;
        }

    }
}
