using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;

namespace Business.Logic.Personas
{
    public abstract class PersonaLogic : LogicBase<Persona, IPersonaRepository>, IPersonaLogic
    {

        public PersonaLogic(Persona entity,
                            IPersonaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

    }

    public abstract class PersonaLogic<TPersona, TPersonaRepository> : LogicBase<TPersona, TPersonaRepository>, IPersonaLogic<TPersona>
        where TPersona : Persona
        where TPersonaRepository : IPersonaRepository<TPersona>
    {
        public PersonaLogic(TPersona entity,
                            TPersonaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

        protected override void Validar(TPersona entity)
        {
            if (entity.State == BusinessEntity.States.New)
            {
                this.Entity = (TPersona)new object();
            }
            else
            {
                this.Entity = this.Repository.GetByID(entity.ID);
            }
        }

        protected override void MapearDatos(TPersona entity)
        {
            base.MapearDatos(entity);
            this.Entity.Nombre = entity.Nombre;
            this.Entity.Apellido = entity.Apellido;
            this.Entity.Direccion = entity.Direccion;
            this.Entity.Email = entity.Email;
            this.Entity.FechaNacimiento = entity.FechaNacimiento.Date;
            this.Entity.Legajo = entity.Legajo;
            this.Entity.Telefono = entity.Telefono;
            this.Entity.State = entity.State;
        }
    }
}
