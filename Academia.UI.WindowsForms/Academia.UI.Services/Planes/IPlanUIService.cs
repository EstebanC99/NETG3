using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IPlanUIService : IUIService<PlanVM>
    {
        List<PlanVM> LeerTodos();

        PlanVM LeerPorID(int ID);

        List<EspecialidadVM> LeerEspecialidades();
    }
}