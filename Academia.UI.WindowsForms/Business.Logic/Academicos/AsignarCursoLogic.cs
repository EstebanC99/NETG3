using Business.Criterias.Personas;
using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Business.Views.AsignarCursos;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos.AsignarCurso;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic.Academicos
{
    public class AsignarCursoLogic : LogicBase<IAsignarCursoRepository>, IAsignarCursoLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        private ICursoLogic CursoLogic { get; set; }

        private IProfesorLogic ProfesorLogic { get; set; }

        public AsignarCursoLogic(IDbContextScopeFactory dbContextScopeFactory,
                                 IAsignarCursoRepository repository,
                                 IEntityLoaderLogicService entityLoaderLogicService,
                                 ICursoLogic cursoLogic,
                                 IProfesorLogic profesorLogic)
            : base(dbContextScopeFactory, repository)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService;
            this.CursoLogic = cursoLogic;
            this.ProfesorLogic = profesorLogic;
        }

        public List<CursoDataView> LeerCursos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.CursoLogic.LeerTodos();
            }
        }

        public List<ProfesorCursoDataView> LeerProfesoresPorPatron(ProfesorCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.ProfesorLogic.BuscarPorCriteria(criteria)
                       .ConvertAll<ProfesorCursoDataView>(p => new ProfesorCursoDataView()
                       {
                           ProfesorID = p.ID,
                           ProfesorNombre = p.Nombre,
                           ProfesorApellido = p.Apellido,
                           ProfesorLegajo = p.Legajo
                       });
            }
        }

        public List<ProfesorCursoDataView> LeerProfesoresPorCurso(int cursoID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.LeerProfesoresPorCurso(cursoID);
            }
        }

        public void AsignarCurso(ProfesorCursoDataView profesorCurso) 
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                var profesor = this.EntityLoaderLogicService.GetByID<Profesor>(profesorCurso.ProfesorID);
                var curso = this.EntityLoaderLogicService.GetByID<Curso>(profesorCurso.ID);

                profesor.AsignarCurso(curso, profesorCurso.Cargo);

                context.SaveChanges();
            }
        }

        public void EliminarCurso(ProfesorCursoDataView profesorCurso)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                var profesor = this.EntityLoaderLogicService.GetByID<Profesor>(profesorCurso.ProfesorID);
                var curso = this.EntityLoaderLogicService.GetByID<Curso>(profesorCurso.ID);

                profesor.EliminarCurso(curso);

                context.SaveChanges();
            }
        }
    }
}
