﻿using Academia.UI.ViewModels;
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

        public void Inscribirse(InscripcionCursoVM inscripcionCursoVM)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<InscripcionCursoVM, InscripcionCursoDataView>());
            var mapper = new Mapper(config);

            this.Logic.Inscribirse(mapper.Map<InscripcionCursoDataView>(inscripcionCursoVM));
        }
    }
}
