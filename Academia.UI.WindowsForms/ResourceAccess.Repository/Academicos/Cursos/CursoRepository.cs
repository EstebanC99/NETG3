using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }


    }
}
