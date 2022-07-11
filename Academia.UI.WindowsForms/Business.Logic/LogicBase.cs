using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository;
using System.Collections.Generic;

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
                this.MapearDatos(entity);
                this.Validar(entity);
                
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

        public TEntity GetByID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetByID(ID);
            }
        }

        public List<TEntity> GetAll()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll();
            }
        }

        protected abstract void Validar(TEntity entity);

        protected virtual void MapearDatos(TEntity entity) 
        {
            this.Entity.State = entity.State;
        }
    }
}
