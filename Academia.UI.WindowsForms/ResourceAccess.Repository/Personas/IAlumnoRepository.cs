using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Personas
{
    public interface IAlumnoRepository : IPersonaRepository<Alumno>
    {
        List<CursoDataView> LeerCursosPorAlumnoLogueado(int alumnoID);
    }
}