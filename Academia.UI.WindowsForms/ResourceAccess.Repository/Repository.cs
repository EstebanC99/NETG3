using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ResourceAccess.Repository
{
    public class Repository<TEntity> : DataAccessBase<AcademiaDbContext>, IRepository<TEntity>
        where TEntity : class, IIdentificable
    {

        public Repository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        protected DbSet<TEntity> DbSet
        {
            get { return this.DbContext.Set<TEntity>(); }
        }

        public TEntity GetByID(int ID)
        {
            return this.DbSet.Find(ID);
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            this.DbSet.Remove(entity);
        }

        public List<TEntity> GetAll()
        {
            return this.DbSet.ToList();
        }

    }
}
