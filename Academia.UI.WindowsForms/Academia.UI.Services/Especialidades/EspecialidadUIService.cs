using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services
{
    public class EspecialidadUIService : UIService<IEspecialidadLogic, EspecialidadVM>, IEspecialidadUIService
    {
        public EspecialidadUIService(IEspecialidadLogic logic) : base(logic)
        {

        }

        public EspecialidadVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID(ID));
        }

        public List<EspecialidadVM> LeerTodos()
        {
            return this.Logic.LeerTodos().Select(this.CrearViewModelDeDataView).ToList();
        }


        #region Metodos de ABM

        public override void Registrar(EspecialidadVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(EspecialidadVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(EspecialidadVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }

        #endregion

        #region Funciones de Conversion

        private readonly Func<EspecialidadDataView, EspecialidadVM> CrearViewModelDeDataView = e =>
        {
            var vm = new EspecialidadVM();

            vm.ID = e.ID;
            vm.Descripcion = e.Descripcion;

            return vm;
        };

        private readonly Func<EspecialidadVM, EspecialidadDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new EspecialidadDataView();

            dv.ID = e.ID;
            dv.Descripcion = e.Descripcion;

            return dv;
        };

        #endregion
    }
}
