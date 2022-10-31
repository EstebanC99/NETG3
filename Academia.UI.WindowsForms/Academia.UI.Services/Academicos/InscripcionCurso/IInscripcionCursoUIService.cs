using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.Academicos.InscripcionCurso
{
    public interface IInscripcionCursoUIService : IUIService
    {
        List<CursoVM> LeerCursos();

        List<CursoVM> LeerCursosPorCriteria(CursoFiltroVM filtroVM);

        List<CursoVM> LeerCursosPorAlumnoLogueado();

        CursoVM LeerCursoPorID(int cursoID);

        void Inscribirse(InscripcionCursoVM inscripcionCursoVM);

        void Desmatricularse(CursoFiltroVM cursoFiltroVM);

        List<AlumnoVM> LeerAlumnosInscriptos(int cursoID);

        List<CursoVM> LeerCursosConCupos();

    }
}