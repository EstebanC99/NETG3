using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface ICursoUIService : IUIService<CursoVM>
    {
        List<CursoVM> LeerTodos();

        CursoVM LeerPorID(int ID);

        List<MateriaVM> LeerMaterias();

        List<ComisionVM> LeerComisiones();
    }
}