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

    }
}
