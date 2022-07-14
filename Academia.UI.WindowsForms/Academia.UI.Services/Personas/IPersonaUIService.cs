using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IPersonaUIService<TViewModel> : IUIService<TViewModel>
        where TViewModel : PersonaVM, new()
    {
        TViewModel LeerPorID(int ID);

        List<TViewModel> LeerTodos();
    }
}
