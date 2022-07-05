using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public class Repository<TEntity> : AcademiaDbContext
        where TEntity : class
    {

        public Repository() 
        {

        }

        public DbSet<TEntity> DbSet
        {
            get { return this.Set<TEntity>(); }
        }

    }
}
