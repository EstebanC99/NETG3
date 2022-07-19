using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Academicos
{
    public class ComisionRepository : Repository<Comision>, IComisionRepository
    {
        public ComisionRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }


    }
}
