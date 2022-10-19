using Academia.UI.ViewModels;
using AutoMapper;
using Business.Criterias;
using Business.Logic.Interfaces;
using Business.Views.ReporteCursos;
using System.Collections.Generic;

namespace Academia.UI.Services.ReporteCursos
{
    public class ReporteCursosUIService : UIService<IReporteCursosLogic>, IReporteCursosUIService
    {
        public ReporteCursosUIService(IReporteCursosLogic logic) : base(logic)
        {

        }

        public List<ReporteCursosItemVM> LeerPorPatron(ReporteCursosFiltroVM filtro)
        {
            var mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReporteCursosFiltroVM, ReporteCursosCriteria>()));

            var resultado = this.Logic.LeerPorPatron(mapper.Map<ReporteCursosCriteria>(filtro));

            mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReporteCursosDataView, ReporteCursosItemVM>()));

            return mapper.Map<List<ReporteCursosDataView>, List<ReporteCursosItemVM>>(resultado);
        }

        public ReporteCursoDetalleVM LeerDetalleCurso(int cursoID)
        {
            var resultado = this.Logic.LeerDetalleCurso(cursoID);

            var mapperAlumnos = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReporteCursoAlumnoDataView, ReporteCursosAlumnoVM>()));


            var mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReporteCursoResultadoDataView, ReporteCursoDetalleVM>()
                                                                      .ForMember(x => x.Alumnos, y => y.Ignore())));

            var detalle = mapper.Map<ReporteCursoDetalleVM>(resultado);
            detalle.Alumnos = mapperAlumnos.Map<List<ReporteCursoAlumnoDataView>, List<ReporteCursosAlumnoVM>>(resultado.Alumnos);

            return detalle;
        }
    }
}
