using Business.Views.AsignarCursos;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Academicos.AsignarCurso
{
    public interface IAsignarCursoRepository : IRepository
    {
        List<ProfesorCursoDataView> LeerProfesoresPorCurso(int cursoID);
    }
}