using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services
{
    public class PlanUIService : UIService<IPlanLogic, PlanVM>, IPlanUIService
    {
        public PlanUIService(IPlanLogic logic) : base(logic)
        {

        }

        public List<PlanVM> LeerTodos()
        {
            return this.Logic.LeerTodos().Select(this.CrearViewModelDeDataView).ToList();
        }

        public PlanVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID(ID));
        }

        public List<EspecialidadVM> LeerEspecialidades()
        {
            return this.Logic.LeerEspecialidades().ConvertAll(e => new EspecialidadVM()
            {
                ID = e.ID,
                Descripcion = e.Descripcion
            });
        }

        #region Metodos de ABM

        public override void Registrar(PlanVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(PlanVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(PlanVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }
        #endregion

        #region Funciones de Conversion

        private readonly Func<PlanDataView, PlanVM> CrearViewModelDeDataView = e =>
        {
            var vm = new PlanVM();
            vm.ID = e.ID;
            vm.Descripcion = e.Descripcion;
            vm.EspecialidadID = e.EspecialidadID;
            vm.EspecialidadDescripcion = e.EspecialidadDescripcion;

            return vm;
        };

        private readonly Func<PlanVM, PlanDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new PlanDataView();
            dv.ID = e.ID;
            dv.Descripcion = e.Descripcion;
            dv.EspecialidadID = e.EspecialidadID;
            dv.EspecialidadDescripcion = e.EspecialidadDescripcion;

            return dv;
        };

        #endregion
    }
}
