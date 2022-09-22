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

    public interface IPersonaUIService: IUIService<PersonaVM>
    {
        List<PersonaVM> LeerTodas();

        PersonaVM LeerPorID(int ID);

        List<PersonaVM> BuscarPorPatron(PersonaFiltroVM filtroVM);
    }
}
