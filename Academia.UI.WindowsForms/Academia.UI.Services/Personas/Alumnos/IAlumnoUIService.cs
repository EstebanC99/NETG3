using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IAlumnoUIService : IPersonaUIService<AlumnoVM>
    {
        List<PlanVM> LeerPlanes();
    }
}