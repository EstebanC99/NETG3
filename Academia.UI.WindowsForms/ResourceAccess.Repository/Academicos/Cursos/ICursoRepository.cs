using Business.Criterias.Cursos;
using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public interface ICursoRepository : IRepository<Curso>
    {
        List<CursoDataView> LeerCursosPorCriterio(CursoCriteria criteria);

        List<AlumnoDataView> LeerAlumnosInscriptos(int cursoID);
    }
}