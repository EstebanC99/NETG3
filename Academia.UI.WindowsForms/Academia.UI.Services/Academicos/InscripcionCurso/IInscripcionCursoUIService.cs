using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.Academicos.InscripcionCurso
{
    public interface IInscripcionCursoUIService : IUIService
    {
        List<CursoVM> LeerCursos();

        List<CursoVM> LeerCursosPorCriteria(CursoFiltroVM filtroVM);

        void Inscribirse(InscripcionCursoVM inscripcionCursoVM);
    }
}