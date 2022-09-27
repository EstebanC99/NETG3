using Academia.UI.ViewModels;
using Business.Criterias.Usuarios;
using Business.Logic.Interfaces;

namespace Academia.UI.Services.Usuarios
{
    public class LoginUIService : UIService<ILoginLogic, LoginVM>, ILoginUIService
    {
        public LoginUIService(ILoginLogic logic) :
            base(logic)
        {

        }

        public LoginVM Login(LoginVM login)
        {
            var criteria = new UsuarioCriteria()
            {
                Username = login.Username,
                Password = login.Password
            };

            var usuario = this.Logic.Login(criteria);

            login.ID = usuario.ID;
            login.RolUsuarioID = usuario.RolUsuarioID;
            login.RolUsuarioDescripcion = usuario.RolUsuarioDescripcion;

            return login;
        }
    }
}
