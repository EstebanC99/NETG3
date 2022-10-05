using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.Academicos.InscripcionCurso
{
    public interface IInscripcionCursoUIService : IUIService
    {
        List<CursoVM> LeerCursos();

        List<CursoVM> LeerCursosPorCriteria(CursoFiltroVM filtroVM);

        List<CursoVM> LeerCursosPorAlumnoLogueado();

        void Inscribirse(InscripcionCursoVM inscripcionCursoVM);

        void Desmatricularse(CursoFiltroVM cursoFiltroVM);
    }
}