using Academia.UI.ViewModels;
using AutoMapper;
using Business.Criterias.Personas;
using Business.Logic.Interfaces;
using Business.Views;
using Business.Views.AsignarCursos;
using System.Collections.Generic;

namespace Academia.UI.Services.Academicos.AsignacionCurso
{
    public class AsignarCursoUIService : UIService<IAsignarCursoLogic>, IAsignarCursoUIService
    {
        public AsignarCursoUIService(IAsignarCursoLogic logic) : base(logic)
        {

        }

        public List<CursoVM> LeerCursos()
        {
            var cursos = this.Logic.LeerCursos();

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<CursoDataView, CursoVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<CursoDataView>, List<CursoVM>>(cursos);
        }

        public List<ProfesorVM> LeerProfesores()
        {
            var profesores = this.Logic.LeerProfesores();

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<ProfesorDataView, ProfesorVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<ProfesorDataView>, List<ProfesorVM>>(profesores);
        }

        public List<ProfesorCursoVM> LeerProfesorPorPatron(string descripcion)
        {
            var criteria = new ProfesorCriteria() { Descripcion = descripcion };

            var profesores = this.Logic.LeerProfesoresPorPatron(criteria);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<ProfesorCursoDataView, ProfesorCursoVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<ProfesorCursoDataView>, List<ProfesorCursoVM>>(profesores);
        }

        public List<ProfesorCursoVM> LeerProfesoresPorCurso(int cursoID)
        {
            var profesoresCurso = this.Logic.LeerProfesoresPorCurso(cursoID);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<ProfesorCursoDataView, ProfesorCursoVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<ProfesorCursoDataView>, List<ProfesorCursoVM>>(profesoresCurso);
        }

        public void AsignarCurso(ProfesorCursoVM profesorCursoVM)
        {

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<ProfesorCursoVM, ProfesorCursoDataView>());
            var mapper = new Mapper(mapperConfig);

            this.Logic.AsignarCurso(mapper.Map<ProfesorCursoDataView>(profesorCursoVM));
        }
    }
}
