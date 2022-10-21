using Academia.UI.ViewModels;
using AutoMapper;
using Business.Criterias;
using Business.Logic.Interfaces;
using Business.Views.ReportePlanes;
using System.Collections.Generic;

namespace Academia.UI.Services.ReportePlanes
{
    public class ReportePlanesUIService : UIService<IReportePlanesLogic>, IReportePlanesUIService
    {
        public ReportePlanesUIService(IReportePlanesLogic logic) : base(logic)
        {

        }

        public List<ReportePlanesVM> LeerPorCriterio(ReportePlanesFiltroVM filtro)
        {
            var mapper = new Mapper(new MapperConfiguration(m => m.CreateMap<ReportePlanesFiltroVM, ReportePlanesCriteria>()));

            var resultado = this.Logic.LeerPorCriterio(mapper.Map<ReportePlanesCriteria>(filtro));

            return resultado.ConvertAll<ReportePlanesVM>(p => new ReportePlanesVM
            {
                ID = p.ID,
                Descripcion = p.Descripcion,
                EspecialidadDescripcion = p.EspecialidadDescripcion,
                Materias = this.MapearToViewModel<ReportePlanesMateriaItemDataView, ReportePlanesMateriaItemVM>(p.Materias),
                Alumnos = this.MapearToViewModel<ReportePlanesAlumnoItemDataView, ReportePlanesAlumnoItemVM>(p.Alumno),
                Comisiones = this.MapearToViewModel<ReportePlanesComisionItemDataView, ReportePlanesComisionItemVM>(p.Comisiones)
            });
        }

        private List<Y> MapearToViewModel<T, Y>(List<T> dataViews)
        {
            var mapper = new Mapper(new MapperConfiguration(m => m.CreateMap<T, Y>()));

            return mapper.Map<List<T>, List<Y>>(dataViews);
        }
    }
}
