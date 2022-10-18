using Business.Criterias.Personas;
using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IProfesorLogic : IPersonaLogic<Profesor>
    {
        List<ProfesorDataView> BuscarPorCriteria(ProfesorCriteria criteria);

        List<CursoDataView> LeerCursosPorProfesorLogueado();
    }
}
