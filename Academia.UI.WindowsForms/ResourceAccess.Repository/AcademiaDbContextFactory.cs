using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository
{
    public class AcademiaDbContextFactory : IDbContextFactory
    {
        public TDbContext CreateDbContext<TDbContext>()
            where TDbContext : class, IDbContext
        {
            return new AcademiaDbContext() as TDbContext;
        }
    }
}
