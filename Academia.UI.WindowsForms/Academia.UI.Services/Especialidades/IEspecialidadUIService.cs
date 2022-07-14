using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IEspecialidadUIService : IUIService<EspecialidadVM>
    {
        EspecialidadVM LeerPorID(int ID);

        List<EspecialidadVM> LeerTodos();
    }
}