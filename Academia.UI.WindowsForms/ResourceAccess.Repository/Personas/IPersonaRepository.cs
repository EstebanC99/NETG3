using Business.Criterias.Personas;
using Business.Entities;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Personas
{
    public interface IPersonaRepository : IRepository<Persona>
    {
        List<Persona> SearchByPattern(PersonaCriteria criteria);
    }

    public interface IPersonaRepository<TPersona> : IRepository<TPersona>
        where TPersona : Persona
    {
        TPersona ObtenerPorLegajo(int nroLegajo);
    }
}