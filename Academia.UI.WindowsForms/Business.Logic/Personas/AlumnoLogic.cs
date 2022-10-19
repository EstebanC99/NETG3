using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;
using Security.Desktop;
using System.Collections.Generic;
using System.Linq;

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

        public List<PlanDataView> LeerPlanes()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.EntityLoaderLogicService.Query<Plan>()
                                                    .Select(p => new PlanDataView()
                                                    {
                                                        ID = p.ID,
                                                        Descripcion = p.Descripcion,
                                                        EspecialidadID = p.Especialidad.ID,
                                                        EspecialidadDescripcion = p.Especialidad.Descripcion
                                                    }).ToList();
            }
        }

        protected override void Validar(PersonaDataView persona)
        {
            base.Validar(persona);

            if (!persona.PlanID.HasValue || persona.PlanID == default(int))
                throw new ValidationException("Debe seleccionar un plan!");
        }

        protected override void Mapear(PersonaDataView persona)
        {
            base.Mapear(persona);

            this.Entity.Plan = this.EntityLoaderLogicService.GetByID<Plan>(persona.PlanID.Value);
        }
    }
}
