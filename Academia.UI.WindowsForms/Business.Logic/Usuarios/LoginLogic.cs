using Business.Criterias.Usuarios;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Usuarios;

namespace Business.Logic.Usuarios
{
    public class LoginLogic : LogicBase<IUsuarioRepository>, ILoginLogic
    {
        public LoginLogic(IDbContextScopeFactory dbContextScopeFactory,
                          IUsuarioRepository repository) :
            base(dbContextScopeFactory, repository)
        {
        }

        public UsuarioDataView Login(UsuarioCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var usuario = this.Repository.Login(criteria);

                if (usuario == null)
                {
                    throw new ValidationException(Messages.UsuarioOContraseniaIncorrectos);
                }

                return new UsuarioDataView()
                {
                    ID = usuario.ID,
                    NombreUsuario = usuario.NombreUsuario,
                    RolUsuarioID = usuario.Rol.ID,
                    RolUsuarioDescripcion = usuario.Rol.Descripcion
                };
            }
        }

    }
}
