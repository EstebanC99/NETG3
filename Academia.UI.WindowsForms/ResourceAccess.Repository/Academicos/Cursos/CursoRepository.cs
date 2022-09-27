using Business.Criterias.Cursos;
using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }

        public List<Curso> LeerCursosPorCriterio(CursoCriteria criteria)
        {
            return this.DbSet.Where(c => (!criteria.AnioCalendario.HasValue || criteria.AnioCalendario == c.AnioCalendario)
                                      && (!criteria.MateriaID.HasValue || criteria.MateriaID == c.Materia.ID)
                                      && (!criteria.ComisionID.HasValue || criteria.ComisionID == c.Comision.ID))
                             .ToList();
        }
    }
}
