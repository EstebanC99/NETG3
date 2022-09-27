using Business.Criterias.Cursos;
using Business.Entities;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public interface ICursoRepository : IRepository<Curso>
    {
        List<Curso> LeerCursosPorCriterio(CursoCriteria criteria);
    }
}