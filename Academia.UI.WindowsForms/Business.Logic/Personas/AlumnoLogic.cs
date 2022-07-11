using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;

namespace Business.Logic.Personas
{
    public class AlumnoLogic : PersonaLogic<Alumno, IAlumnoRepository>, IAlumnoLogic
    {
        public AlumnoLogic(Alumno entity,
                           IAlumnoRepository repository,
                           IDbContextScopeFactory dbContextScopeFactory) :
            base(entity, repository, dbContextScopeFactory)
        {
            
        }


    }
}
