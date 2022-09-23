using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;

namespace Business.Logic.Personas
{
    public class AdministradorLogic : PersonaLogic<Administrador, IAdministradorRepository>, IAdministradorLogic
    {
        public AdministradorLogic(Administrador entity,
                                  IAdministradorRepository repository,
                                  IDbContextScopeFactory dbContextScopeFactory) :
            base(entity, repository, dbContextScopeFactory)
        {

        }



    }
}
