using EntityFramework.DbContextScope.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public abstract class DataAccessBase<TDbContext> : IDataAccessBase
        where TDbContext : class, IDbContext
    {
        private readonly IAmbientDbContextLocator ambientDbContextLocator;

        protected TDbContext DbContext
        {
            get
            {
                var dbContext = this.ambientDbContextLocator.Get<TDbContext>();

                if (dbContext == null)
                    throw new InvalidOperationException("No Context set");

                return dbContext;
            }
        }

        protected DataAccessBase(IAmbientDbContextLocator ambientDbContextLocator)
        {
            if (ambientDbContextLocator == null)
                throw new ArgumentNullException(nameof(ambientDbContextLocator));

            this.ambientDbContextLocator = ambientDbContextLocator;
        }
    }
}
