using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services
{
    public interface IProfesorUIService : IPersonaUIService<ProfesorVM>
    {
        List<CursoVM> LeerCursosPorProfesorLogueado();
    }
}