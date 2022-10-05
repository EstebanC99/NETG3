using Business.Criterias.Personas;
using Business.Views;
using Business.Views.AsignarCursos;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IAsignarCursoLogic : ILogicBase
    {
        List<CursoDataView> LeerCursos();

        List<ProfesorDataView> LeerProfesores();

        List<ProfesorCursoDataView> LeerProfesoresPorPatron(ProfesorCriteria criteria);

        List<ProfesorCursoDataView> LeerProfesoresPorCurso(int cursoID);

        void AsignarCurso(ProfesorCursoDataView profesorCurso);
    }
}
