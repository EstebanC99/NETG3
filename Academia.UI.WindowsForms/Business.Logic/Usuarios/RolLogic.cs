using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Usuarios;

namespace Business.Logic.Usuarios
{
    public class RolLogic : LogicBase<Rol, IRolRepository>, IRolLogic
    {
        public RolLogic(IDbContextScopeFactory dbContextScopeFactory,
                        IRolRepository repository) :
            base(dbContextScopeFactory, repository)
        {
        }
    }
}
