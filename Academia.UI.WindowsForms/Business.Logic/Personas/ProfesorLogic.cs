using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope;
using ResourceAccess.Repository.Personas;

namespace Business.Logic.Personas
{
    public class ProfesorLogic : PersonaLogic<Profesor, IProfesorRepository>, IProfesorLogic
    {
        public ProfesorLogic(Profesor entity,
                             IProfesorRepository repository,
                             DbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {
            
        }

        protected override void MapearDatos(Profesor entity)
        {
            if (entity.State == BusinessEntity.States.New)
            {
                this.Entity = new Profesor();
            }
            else
            {
                this.Entity = this.Repository.GetByID(entity.ID);
            }

            base.MapearDatos(entity);
        }
    }
}
