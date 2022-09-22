using Business.Criterias.Usuarios;
using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using System.Linq;

namespace ResourceAccess.Repository.Usuarios
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        public Usuario Login(UsuarioCriteria criteria)
        {
            return this.DbSet.FirstOrDefault(u => u.NombreUsuario == criteria.Username 
                                               && u.Clave == criteria.Password 
                                               && u.Habilitado);
        }
    }
}
