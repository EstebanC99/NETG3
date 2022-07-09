using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Personas
{
    public class ProfesorRepository : PersonaRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }
    }
}
