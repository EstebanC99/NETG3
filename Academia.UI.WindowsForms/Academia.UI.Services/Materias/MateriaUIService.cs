using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services.Materias
{
    public class MateriaUIService : UIService<IMateriaLogic, MateriaVM>, IMateriaUIService
    {
        public MateriaUIService(IMateriaLogic logic)
            : base(logic)
        {

        }

        public List<MateriaVM> LeerTodos()
        {
            return this.Logic.LeerTodos().Select(this.CrearViewModelDeDataView).ToList();
        }

        public MateriaVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID(ID));
        }

        public List<PlanVM> LeerPlanes()
        {
            return this.Logic.LeerPlanes().ConvertAll(e => new PlanVM()
            {
                ID = e.ID,
                Descripcion = e.Descripcion
            });
        }

        #region Metodos de ABM

        public override void Registrar(MateriaVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(MateriaVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(MateriaVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }
        #endregion

        #region Funciones de Conversion

        private readonly Func<MateriaDataView, MateriaVM> CrearViewModelDeDataView = e =>
        {
            var vm = new MateriaVM();
            vm.ID = e.ID;
            vm.Descripcion = e.Descripcion;
            vm.HsSemanales = e.HsSemanales;
            vm.HsTotales = e.HsTotales;
            vm.PlanID = e.PlanID;
            vm.PlanDescripcion = e.PlanDescripcion;

            return vm;
        };

        private readonly Func<MateriaVM, MateriaDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new MateriaDataView();
            dv.ID = e.ID;
            dv.Descripcion = e.Descripcion;
            dv.HsSemanales = e.HsSemanales;
            dv.HsTotales = e.HsTotales;
            dv.PlanID = e.PlanID ?? default(int);
            dv.PlanDescripcion = e.PlanDescripcion;

            return dv;
        };

        #endregion
    }
}
