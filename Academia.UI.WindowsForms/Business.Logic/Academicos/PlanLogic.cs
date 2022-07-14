using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos;
using System.Collections.Generic;

namespace Business.Logic.Academicos
{
    public class PlanLogic : LogicBase<PlanDataView, Plan, IPlanRepository>, IPlanLogic
    {
        private IEspecialidadLogic EspecialidadLogic { get; set; }

        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        public PlanLogic(Plan entity,
                         IPlanRepository repository,
                         IDbContextScopeFactory dbContextScopeFactory,
                         IEspecialidadLogic especialidadLogic,
                         IEntityLoaderLogicService entityLoaderLogicService)
            : base(entity, repository, dbContextScopeFactory)
        {
            this.EspecialidadLogic = especialidadLogic;
            this.EntityLoaderLogicService = entityLoaderLogicService;
        }

        public List<PlanDataView> LeerTodos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => new PlanDataView()
                {
                    ID = m.ID,
                    Descripcion = m.Descripcion,
                    EspecialidadID = m.Especialidad.ID,
                    EspecialidadDescripcion = m.Especialidad.Descripcion
                });
            }
        }

        public PlanDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new PlanDataView()
                {
                    ID = this.Entity.ID,
                    Descripcion = this.Entity.Descripcion,
                    EspecialidadID = this.Entity.Especialidad.ID,
                    EspecialidadDescripcion = this.Entity.Especialidad.Descripcion
                };
            }
        }

        public List<EspecialidadDataView> LeerEspecialidades()
        {
            return this.EspecialidadLogic.LeerTodos();
        }

        #region Metodos Protegidos

        protected override void Validar(PlanDataView plan)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(plan.Descripcion))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(plan.Descripcion)));

            if (this.Entity.Especialidad == null)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Especialidad)));

            validaciones.Throw();
        }

        protected override void Mapear(PlanDataView plan)
        {
            this.Entity.Descripcion = plan.Descripcion;
            this.Entity.Especialidad = this.EntityLoaderLogicService.GetByID<Especialidad>(plan.EspecialidadID);
        }

        #endregion

    }
}
