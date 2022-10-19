using Business.Criterias;
using Business.Logic.Interfaces;
using Business.Views.ReporteCursos;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos.ReporteCursos;
using System.Collections.Generic;

namespace Business.Logic.Academicos
{
    public class ReporteCursosLogic : LogicBase<IReporteCursosRepository>, IReporteCursosLogic
    {
        public ReporteCursosLogic(IDbContextScopeFactory dbContextScopeFactory,
                                  IReporteCursosRepository repository)
            : base(dbContextScopeFactory, repository)
        {

        }

        public List<ReporteCursosDataView> LeerPorPatron(ReporteCursosCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.LeerPorPatron(criteria);
            }
        }

        public ReporteCursoResultadoDataView LeerDetalleCurso(int cursoID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.LeerDetalleCurso(cursoID);
            }
        }
    }
}
