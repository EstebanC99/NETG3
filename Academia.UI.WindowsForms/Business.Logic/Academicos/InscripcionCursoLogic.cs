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

        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }


        public InscripcionCursoLogic(DbContextScopeFactory dbContextScopeFactory,
                                     ICursoLogic cursoLogic,
                                     IEntityLoaderLogicService entityLoaderLogicService) : base(dbContextScopeFactory)
        {
            this.CursoLogic = cursoLogic;
            this.EntityLoaderLogicService = entityLoaderLogicService;
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
                return this.CursoLogic.LeerCursosPorCriterio(criteria);
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

    }
}
