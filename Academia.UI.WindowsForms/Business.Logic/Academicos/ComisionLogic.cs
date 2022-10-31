using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos;
using System.Collections.Generic;

namespace Business.Logic.Academicos
{
    public class ComisionLogic : LogicBase<ComisionDataView, Comision, IComisionRepository>, IComisionLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        private IPlanLogic PlanLogic { get; set; }

        public ComisionLogic(Comision entity,
                             IComisionRepository repository,
                             IDbContextScopeFactory dbContextScopeFactory,
                             IEntityLoaderLogicService entityLoaderLogicService,
                             IPlanLogic planLogic)
            : base(entity, repository, dbContextScopeFactory)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService;
            this.PlanLogic = planLogic;
        }

        public List<ComisionDataView> LeerTodos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => new ComisionDataView()
                {
                    ID = m.ID,
                    Descripcion = m.Descripcion,
                    AnioEspecialidad = m.AnioEspecialidad,
                    PlanID = m.Plan != null ? m.Plan.ID : default(int),
                    PlanDescripcion = m.Plan?.Descripcion
                });
            }
        }

        public ComisionDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new ComisionDataView()
                {
                    ID = this.Entity.ID,
                    Descripcion = this.Entity.Descripcion,
                    AnioEspecialidad = this.Entity.AnioEspecialidad,
                    PlanID = this.Entity.Plan != null ? this.Entity.Plan.ID : default(int),
                    PlanDescripcion = this.Entity.Plan?.Descripcion
                };
            }
        }

        public List<PlanDataView> LeerPlanes()
        {
            return this.PlanLogic.LeerTodos();
        }

        #region Metodos Protegidos

        protected override void Mapear(ComisionDataView comision)
        {
            this.Entity.Descripcion = comision.Descripcion;
            this.Entity.AnioEspecialidad = comision.AnioEspecialidad;
            this.Entity.Plan = this.EntityLoaderLogicService.GetByID<Plan>(comision.PlanID);
        }

        protected override void Validar(ComisionDataView comision)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(comision.Descripcion))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, comision.Descripcion));

            if (comision.AnioEspecialidad == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, comision.AnioEspecialidad));

            if (comision.PlanID == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Plan)));

            validaciones.Throw();
        }

        #endregion
    }
}
