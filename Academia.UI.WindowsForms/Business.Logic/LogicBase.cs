using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository;

namespace Business.Logic
{
    public abstract class LogicBase<TEntity, TRepository> : ILogicBase<TEntity>
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

        public void GuardarCambios(TEntity entity)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                entity.Validar();

                this.Entity = entity;

                switch (this.Entity.State)
                {
                    case BusinessEntity.States.New:
                        this.Repository.Add(this.Entity);
                        break;
                    case BusinessEntity.States.Deleted:
                        this.Repository.Remove(this.Entity);
                        break;
                    default:
                        break;
                }

                context.SaveChanges();
            }
        }

    }
}
