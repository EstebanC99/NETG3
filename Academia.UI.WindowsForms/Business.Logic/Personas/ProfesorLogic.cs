using Business.Criterias.Personas;
using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using EntityFramework.DbContextScope;
using ResourceAccess.Repository.Personas;
using System.Collections.Generic;

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

        public List<ProfesorDataView> BuscarPorCriteria(ProfesorCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.SearchByPattern(criteria);
            }
        }
    }
}
