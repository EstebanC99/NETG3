using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

    }
}
