using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.Materias
{
    public interface IMateriaUIService : IUIService<MateriaVM>
    {
        List<MateriaVM> LeerTodos();

        MateriaVM LeerPorID(int ID);

        List<PlanVM> LeerPlanes();
    }
}