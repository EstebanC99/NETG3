using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Academicos
{
    public class EspecialidadRepository : Repository<Especialidad>, IEspecialidadRepository
    {
        public EspecialidadRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }


    }
}
