using Business.Criterias.Usuarios;
using Business.Entities;

namespace ResourceAccess.Repository.Usuarios
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario Login(UsuarioCriteria criteria);
    }
}