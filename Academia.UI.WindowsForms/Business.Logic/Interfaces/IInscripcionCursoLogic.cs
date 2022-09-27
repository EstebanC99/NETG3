using Business.Criterias.Cursos;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic.Interfaces
{
    public interface IInscripcionCursoLogic : ILogicBase
    {
        List<CursoDataView> LeerCursos();

        List<CursoDataView> LeerCursosPorCriterio(CursoCriteria criteria);

        void Inscribirse(InscripcionCursoDataView criteria);
    }
}
