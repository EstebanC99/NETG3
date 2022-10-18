using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views.Cursos;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos.Cursos;
using System.Linq;

namespace Business.Logic.Academicos
{
    public class IngresarNotaLogic : LogicBase<IIngresarNotaRepository>, IIngresarNotaLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        public IngresarNotaLogic(IDbContextScopeFactory dbContextScopeFactory,
                                 IIngresarNotaRepository repository,
                                 IEntityLoaderLogicService entityLoaderLogicService)
            : base(dbContextScopeFactory, repository)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService;
        }

        public InscripcionDataView LeerInscripcionPorID(int inscripcionID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.LeerInscripcionPorID(inscripcionID);
            }
        }

        public void RegistrarNota(InscripcionDataView inscripcion)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                var alumno = this.EntityLoaderLogicService.Query<Alumno>().FirstOrDefault(a => a.ID == inscripcion.AlumnoID);

                alumno.RegistrarNota(inscripcion.ID, inscripcion.Nota);

                context.SaveChanges();
            }
        }
    }
}
