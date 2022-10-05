using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.Academicos.AsignacionCurso
{
    public interface IAsignarCursoUIService: IUIService
    {
        List<CursoVM> LeerCursos();

        List<ProfesorCursoVM> LeerProfesorPorPatron(string descripcion);

        List<ProfesorCursoVM> LeerProfesoresPorCurso(int cursoID);

        void AsignarCurso(ProfesorCursoVM profesorCursoVM);

        void EliminarCurso(ProfesorCursoVM profesorCursoVM);
    }
}