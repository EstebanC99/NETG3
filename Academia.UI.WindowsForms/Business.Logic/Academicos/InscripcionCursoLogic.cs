using Business.Criterias.Cursos;
using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope;
using Security.Desktop;
using System.Collections.Generic;
using static Business.Entities.Global.TiposPersonas;

namespace Business.Logic.Academicos
{
    public class InscripcionCursoLogic : LogicBase, IInscripcionCursoLogic
    {
        private ICursoLogic CursoLogic { get; set; }

        private IAlumnoLogic AlumnoLogic { get; set; }

        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }


        public InscripcionCursoLogic(DbContextScopeFactory dbContextScopeFactory,
                                     ICursoLogic cursoLogic,
                                     IEntityLoaderLogicService entityLoaderLogicService,
                                     IAlumnoLogic alumnoLogic) : base(dbContextScopeFactory)
        {
            this.CursoLogic = cursoLogic;
            this.EntityLoaderLogicService = entityLoaderLogicService;
            this.AlumnoLogic = alumnoLogic;
        }

        public List<CursoDataView> LeerCursos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.CursoLogic.LeerTodos();
            }
        }

        public List<CursoDataView> LeerCursosPorCriterio(CursoCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                criteria.AlumnoID = this.EntityLoaderLogicService.GetByID<Usuario>(SessionInfo.Instance.UserID.Value)?.Persona.ID;

                return this.CursoLogic.LeerCursosPorCriterio(criteria);
            }
        }

        public List<CursoDataView> LeerCursosPorALumnoLogueado()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.AlumnoLogic.LeerCursosPorALumnoLogueado();
            }
        }

        public void Inscribirse(InscripcionCursoDataView criteria)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                var usuario = this.EntityLoaderLogicService.GetByID<Usuario>(SessionInfo.Instance.UserID.Value);

                if (usuario.Persona.TipoPersona != (int)TiposPersona.Alumno)
                {
                    throw new ValidationException(Messages.AccionNoAutorizadaParaElUsuario);
                }

                var alumno = this.EntityLoaderLogicService.GetByID<Alumno>(usuario.Persona.ID);
                var curso = this.EntityLoaderLogicService.GetByID<Curso>(criteria.CursoID);

                alumno.Inscribir(curso);

                context.SaveChanges();
            }
        }

        public void Desmatricularse(CursoCriteria criteria)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                var personaID = this.EntityLoaderLogicService.GetByID<Usuario>(SessionInfo.Instance.UserID.Value)?.Persona.ID;

                var alumno = this.EntityLoaderLogicService.GetByID<Alumno>(personaID ?? default(int));

                var curso = this.EntityLoaderLogicService.GetByID<Curso>(criteria.ID);

                if (alumno == null || curso == null)
                    throw new ValidationException(Messages.SinResultados);

                alumno.Desmatricularse(curso);

                context.SaveChanges();
            }
        }
    }
}
