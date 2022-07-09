using Business.Entities;

namespace ResourceAccess.Repository.Personas
{
    public interface IPersonaRepository : IRepository<Persona>
    {
    }

    public interface IPersonaRepository<TPersona> : IRepository<TPersona>
        where TPersona : Persona
    {
        
    }
}