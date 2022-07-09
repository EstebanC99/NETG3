using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Usuarios
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

    }
}
