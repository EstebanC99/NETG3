using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Usuarios
{
    public class RolRepository : Repository<Rol>, IRolRepository
    {
        public RolRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }
    }
}
