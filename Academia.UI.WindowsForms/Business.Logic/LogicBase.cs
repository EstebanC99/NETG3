using Business.Entities;
using Business.Views;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository;
using System;
using System.Collections.Generic;

namespace Business.Logic
{
    public abstract class LogicBase : ILogicBase
    {
        protected LogicBase()
        {

        }
    }

    public abstract class LogicBase<TRepository> : LogicBase
        where TRepository : IDataAccessBase
    {
        protected IDbContextScopeFactory DbContextScopeFactory { get; private set; }

        protected TRepository Repository { get; private set; }

        protected LogicBase(IDbContextScopeFactory dbContextScopeFactory, TRepository repository)
        {
            this.DbContextScopeFactory = dbContextScopeFactory;
            this.Repository = repository;
        }
    }

    public abstract class LogicBase<TEntity, TRepository>: LogicBase<TRepository>
        where TRepository: IRepository<TEntity>
        where TEntity: BusinessEntity
    {
        protected LogicBase(IDbContextScopeFactory dbContextScopeFactory, TRepository repository)
            : base(dbContextScopeFactory, repository)
        {

        }

        public List<DataView> GetAll()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll<DataView>(p => new DataView()
                {
                    ID = p.ID,
                    Descripcion = p.Descripcion
                });
            }
        }
    }

    public abstract class LogicBase<TDataView, TEntity, TRepository> : ILogicBase<TDataView, TEntity>
        where TEntity : BusinessEntity
        where TRepository : IRepository<TEntity>
        where TDataView : DataView
    {
        #region Propiedades

        protected TEntity Entity { get; set; }

        protected TRepository Repository { get; set; }

        protected IDbContextScopeFactory DbContextScopeFactory { get; private set; }

        public LogicBase(TEntity entity, TRepository repository, IDbContextScopeFactory dbContextScopeFactory)
             : base()
        {
            this.Entity = entity;
            this.Repository = repository;
            this.DbContextScopeFactory = dbContextScopeFactory;
        }

        #endregion

        #region Metodos ABM

        public void Registrar(TDataView dataView)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                this.Validar(dataView);

                this.Entity = (TEntity)Activator.CreateInstance(typeof(TEntity));

                this.Mapear(dataView);

                this.Repository.Add(this.Entity);

                context.SaveChanges();
            }
        }

        public void Modificar(TDataView dataView)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                this.Validar(dataView);

                this.Entity = this.Repository.GetByID(dataView.ID);

                this.Mapear(dataView);

                context.SaveChanges();
            }
        }

        public void Eliminar(TDataView dataView)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                this.Entity = this.Repository.GetByID(dataView.ID);

                this.Repository.Remove(this.Entity);

                context.SaveChanges();
            }
        }

        #endregion

        public virtual DataView GetByID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var entity = this.Repository.GetByID(ID);

                return new DataView()
                {
                    ID = entity.ID,
                    Descripcion = entity.Descripcion
                };
            }
        }

        public virtual List<DataView> GetAll()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => new DataView()
                {
                    ID = m.ID,
                    Descripcion = m.Descripcion
                });
            }
        }

        #region Metodos Protegidos

        protected abstract void Validar(TDataView dataView);

        protected abstract void Mapear(TDataView dataView);

        #endregion
    }
}
