using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public class Repository<TEntity> : DbContext
        where TEntity : class
    {

        public DbSet<TEntity> DbSet
        {
            get { return this.Set<TEntity>(); }
        }

    }
}
