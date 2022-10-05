using Business.Criterias.Cursos;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IInscripcionCursoLogic : ILogicBase
    {
        List<CursoDataView> LeerCursos();

        List<CursoDataView> LeerCursosPorCriterio(CursoCriteria criteria);

        List<CursoDataView> LeerCursosPorALumnoLogueado();

        void Inscribirse(InscripcionCursoDataView criteria);

        void Desmatricularse(CursoCriteria criteria);
    }
}
