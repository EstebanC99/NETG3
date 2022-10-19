using Business.Criterias;
using Business.Views.ReporteCursos;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IReporteCursosLogic : ILogicBase
    {
        List<ReporteCursosDataView> LeerPorPatron(ReporteCursosCriteria criteria);

        ReporteCursoResultadoDataView LeerDetalleCurso(int cursoID);
    }
}
