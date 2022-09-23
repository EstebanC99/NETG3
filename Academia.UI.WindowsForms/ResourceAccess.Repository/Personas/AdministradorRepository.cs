using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Personas
{
    public class AdministradorRepository : PersonaRepository<Administrador>, IAdministradorRepository
    {
        public AdministradorRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }
    }
}
