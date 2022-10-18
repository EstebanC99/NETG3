using Academia.UI.ViewModels;
using AutoMapper;
using Business.Criterias.Cursos;
using Business.Logic.Interfaces;
using Business.Views;
using System.Collections.Generic;

namespace Academia.UI.Services.Academicos.InscripcionCurso
{
    public class InscripcionCursoUIService : UIService<IInscripcionCursoLogic>, IInscripcionCursoUIService
    {
        public InscripcionCursoUIService(IInscripcionCursoLogic logic) : base(logic)
        {

        }

        public List<CursoVM> LeerCursos()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CursoDataView, CursoVM>());
            var mapper = new Mapper(config);

            var cursosDataView = this.Logic.LeerCursos();

            return mapper.Map<List<CursoDataView>,List<CursoVM>>(cursosDataView);
        }

        public List<CursoVM> LeerCursosPorCriteria(CursoFiltroVM filtroVM)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CursoFiltroVM, CursoCriteria>());
            var mapper = new Mapper(config);

            var resultado = this.Logic.LeerCursosPorCriterio(mapper.Map<CursoCriteria>(filtroVM));

            config = new MapperConfiguration(cfg => cfg.CreateMap<CursoDataView, CursoVM>());
            mapper = new Mapper(config);

            return mapper.Map<List<CursoDataView>, List<CursoVM>>(resultado);
        }

        public List<CursoVM> LeerCursosPorAlumnoLogueado()
        {
            var m = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CursoDataView, CursoVM>();
            });

            var cursos = new Mapper(m).Map<List<CursoDataView>, List<CursoVM>>(this.Logic.LeerCursosPorALumnoLogueado());

            return cursos;
        }

        public CursoVM LeerCursoPorID(int cursoID)
        {
            var curso = this.Logic.LeerCursoPorID(cursoID);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<CursoDataView, CursoVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<CursoVM>(curso);
        }

        public void Inscribirse(InscripcionCursoVM inscripcionCursoVM)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<InscripcionCursoVM, InscripcionCursoDataView>());
            var mapper = new Mapper(config);

            this.Logic.Inscribirse(mapper.Map<InscripcionCursoDataView>(inscripcionCursoVM));
        }

        public void Desmatricularse(CursoFiltroVM cursoFiltroVM)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CursoFiltroVM, CursoCriteria>());
            var mapper = new Mapper(config);

            this.Logic.Desmatricularse(mapper.Map<CursoCriteria>(cursoFiltroVM));
        }

        public List<AlumnoVM> LeerAlumnosInscriptos(int cursoID)
        {
            var inscriptos = this.Logic.LeerAlumnosInscriptos(cursoID);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDataView, AlumnoVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<AlumnoDataView>, List<AlumnoVM>>(inscriptos);
        }
    }
}
