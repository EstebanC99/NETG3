using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IAlumnoLogic : IPersonaLogic<Alumno>
    {
        List<CursoDataView> LeerCursosPorALumnoLogueado();

        List<PlanDataView> LeerPlanes();
    }
}
