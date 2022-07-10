using Business.Entities;
using Business.Logic.Interfaces;
using EntityFramework.DbContextScope;
using ResourceAccess.Repository.Academicos;

namespace Business.Logic.Academicos
{
    public class EspecialidadLogic : LogicBase<Especialidad, IEspecialidadRepository>, IEspecialidadLogic
    {
        public EspecialidadLogic(Especialidad entity, IEspecialidadRepository repository, DbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

        protected override void Validar(Especialidad entity)
        {
            // Aca las validaciones

            this.Entity = entity;
        }
    }
}
