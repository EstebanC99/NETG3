using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos;
using System.Collections.Generic;

namespace Business.Logic.Academicos
{
    public class MateriaLogic : LogicBase<MateriaDataView, Materia, IMateriaRepository>, IMateriaLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        private IPlanLogic PlanLogic { get; set; }

        public MateriaLogic(Materia entity,
                            IMateriaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory,
                            IEntityLoaderLogicService entityLoaderLogicService,
                            IPlanLogic planLogic)
            : base(entity, repository, dbContextScopeFactory)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService;
            this.PlanLogic = planLogic;
        }

        public List<MateriaDataView> LeerTodos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => new MateriaDataView()
                {
                    ID = m.ID,
                    Descripcion = m.Descripcion,
                    HsSemanales = m.HsSemanales,
                    HsTotales = m.HsTotales,
                    PlanID = m.Plan !=  null ? m.Plan.ID : default(int),
                    PlanDescripcion = m.Plan?.Descripcion
                });
            }
        }

        public MateriaDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new MateriaDataView()
                {
                    ID = this.Entity.ID,
                    Descripcion = this.Entity.Descripcion,
                    HsSemanales = this.Entity.HsSemanales,
                    HsTotales = this.Entity.HsTotales,
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

        protected override void Mapear(MateriaDataView materia)
        {
            this.Entity.Descripcion = materia.Descripcion;
            this.Entity.HsSemanales = materia.HsSemanales;
            this.Entity.HsTotales = materia.HsTotales;
            this.Entity.Plan = this.EntityLoaderLogicService.GetByID<Plan>(materia.PlanID);
        }

        protected override void Validar(MateriaDataView materia)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(materia.Descripcion))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(materia.Descripcion)));

            if (materia.HsSemanales == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, nameof(materia.HsSemanales)));

            if (materia.HsTotales == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, nameof(materia.HsTotales)));

            if (materia.PlanID == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Plan)));

            validaciones.Throw();
        }

        #endregion
    }
}
