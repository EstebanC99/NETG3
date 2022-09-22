using Business.Criterias.Personas;
using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository.Personas
{
    public class PersonaRepository : Repository<Persona>, IPersonaRepository
    {
        public PersonaRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        public List<Persona> SearchByPattern(PersonaCriteria criteria)
        {
            return this.DbSet.Where(p => p.Nombre.Contains(criteria.Descripcion)
                                      || p.Apellido.Contains(criteria.Descripcion))
                             .ToList();
        }

    }

    public class PersonaRepository<TPersona> : Repository<TPersona>, IPersonaRepository<TPersona>
        where TPersona : Persona
    {
        public PersonaRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        public TPersona ObtenerPorLegajo(int nroLegajo)
        {
            return this.DbSet.Where(p => p.Legajo == nroLegajo).FirstOrDefault();
        }
    }
}
