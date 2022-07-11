using Business.Entities;
using Business.Logic.Interfaces;
using Cross.Exceptions;
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

        protected override void MapearDatos(Especialidad entity)
        {
            if (entity.State == BusinessEntity.States.New)
            {
                this.Entity = new Especialidad();
            }
            else
            {
                this.Entity = this.Repository.GetByID(entity.ID);
            }

            base.MapearDatos(entity);

            this.Entity.Descripcion = entity.Descripcion;
        }

        protected override void Validar(Especialidad entity)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(this.Entity.Descripcion))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, this.Entity.Descripcion));

            validaciones.Throw();
        }
    }
}
