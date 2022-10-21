using Academia.UI.ViewModels;
using System.Collections.Generic;

namespace Academia.UI.Services.ReportePlanes
{
    public interface IReportePlanesUIService : IUIService
    {
        List<ReportePlanesVM> LeerPorCriterio(ReportePlanesFiltroVM filtro);
    }
}