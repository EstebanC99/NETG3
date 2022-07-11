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

    }
}
