using Business.Criterias;
using Business.Logic.Interfaces;
using Business.Views.ReportePlanes;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos.ReportePlanes;
using System.Collections.Generic;

namespace Business.Logic.Academicos
{
    public class ReportePlanesLogic : LogicBase<IReportePlanesRepository>, IReportePlanesLogic
    {
        public ReportePlanesLogic(IDbContextScopeFactory dbContextScopeFactory,
                                  IReportePlanesRepository repository)
            : base(dbContextScopeFactory, repository)
        {

        }

        public List<ReportePlanesDataView> LeerPorCriterio(ReportePlanesCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.LeerPorCriterio(criteria);
            }
        }
    }
}
