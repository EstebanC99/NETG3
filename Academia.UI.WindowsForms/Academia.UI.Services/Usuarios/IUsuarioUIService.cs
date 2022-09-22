using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IUsuarioUIService : IUIService<UsuarioVM>
    {
        UsuarioVM LeerPorID(int ID);

        List<UsuarioVM> LeerTodos();

        List<ViewModel> LeerRoles();
    }
}