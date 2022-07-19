using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IComisionUIService : IUIService<ComisionVM>
    {
        List<ComisionVM> LeerTodos();

        ComisionVM LeerPorID(int ID);

        List<PlanVM> LeerPlanes();
    }
}