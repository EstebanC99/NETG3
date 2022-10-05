using Business.Criterias.Personas;
using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace ResourceAccess.Repository.Personas
{
    public interface IProfesorRepository : IPersonaRepository<Profesor>
    {
        List<ProfesorDataView> SearchByPattern(ProfesorCriteria criteria);
    }
}