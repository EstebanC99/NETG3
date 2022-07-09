using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;
using System.Collections.Generic;
using System.Linq;

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

        public List<TPersona> GetAll() 
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll();
            }
        }

        private void ValidarPersona(TPersona persona)
        {
            // Aca las validaciones

            this.Entity = persona;
        }

    }
}
