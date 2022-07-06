using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public class Repository<TEntity> : AcademiaDbContext, IRepository<TEntity>
        where TEntity : BusinessEntity
    {

        public Repository() 
        {

        }

        public DbSet<TEntity> DbSet
        {
            get { return this.Set<TEntity>(); }
        }

        public TEntity GetByID(int ID)
        {
            return this.DbSet.FirstOrDefault(o => o.ID == ID);
        }

        public List<TEntity> GetAll()
        {
            return this.DbSet.ToList();
        }

    }
}
