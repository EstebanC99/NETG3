using Business.Criterias;
using Business.Entities;
using Business.Views.ReportePlanes;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Academicos.ReportePlanes
{
    public interface IReportePlanesRepository : IRepository<Plan>
    {
        List<ReportePlanesDataView> LeerPorCriterio(ReportePlanesCriteria criteria);
    }
}