using Business.Criterias;
using Business.Entities;
using Business.Views.ReporteCursos;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Academicos.ReporteCursos
{
    public interface IReporteCursosRepository : IRepository<Curso>
    {
        List<ReporteCursosDataView> LeerPorPatron(ReporteCursosCriteria criteria);

        ReporteCursoResultadoDataView LeerDetalleCurso(int cursoID);
    }
}