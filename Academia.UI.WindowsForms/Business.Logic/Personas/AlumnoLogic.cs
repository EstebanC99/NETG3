using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;
using Security.Desktop;
using System.Collections.Generic;

namespace Business.Logic.Personas
{
    public class AlumnoLogic : PersonaLogic<Alumno, IAlumnoRepository>, IAlumnoLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        public AlumnoLogic(Alumno entity,
                           IAlumnoRepository repository,
                           IDbContextScopeFactory dbContextScopeFactory,
                           IEntityLoaderLogicService entityLoaderLogicService) :
            base(entity, repository, dbContextScopeFactory)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService; 
        }

        public List<CursoDataView> LeerCursosPorALumnoLogueado()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var alumno = this.EntityLoaderLogicService.GetByID<Usuario>(SessionInfo.Instance.UserID.Value)?.Persona;

                if (alumno == null)
                    return new List<CursoDataView>();

                return this.Repository.LeerCursosPorAlumnoLogueado(alumno.ID);
            }
        }
    }
}
