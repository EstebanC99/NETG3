using Business.Criterias.Personas;
using Business.Entities;
using Business.Views;
using EntityFramework.DbContextScope.Interfaces;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Personas
{
    public class ProfesorRepository : PersonaRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }


        public List<ProfesorDataView> SearchByPattern(ProfesorCriteria criteria)
        {
            return base.SearchByPattern(criteria).ConvertAll<ProfesorDataView>(p => new ProfesorDataView()
            {
                ID = p.ID,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Legajo = p.Legajo,
            });
        }
    }
}
