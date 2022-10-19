using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.ReporteCursos
{
    public interface IReporteCursosUIService : IUIService
    {
        List<ReporteCursosItemVM> LeerPorPatron(ReporteCursosFiltroVM filtro);

        ReporteCursoDetalleVM LeerDetalleCurso(int cursoID);
    }
}