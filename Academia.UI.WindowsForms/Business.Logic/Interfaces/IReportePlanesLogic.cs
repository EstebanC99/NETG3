using Business.Criterias;
using Business.Views.ReportePlanes;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IReportePlanesLogic : ILogicBase
    {
        List<ReportePlanesDataView> LeerPorCriterio(ReportePlanesCriteria criteria);
    }
}