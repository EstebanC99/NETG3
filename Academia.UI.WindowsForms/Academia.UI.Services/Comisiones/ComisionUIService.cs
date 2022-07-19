using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.UI.Services
{
    public class ComisionUIService : UIService<IComisionLogic, ComisionVM>, IComisionUIService
    {
        public ComisionUIService(IComisionLogic logic) : base(logic)
        {

        }

        public List<ComisionVM> LeerTodos()
        {
            return this.Logic.LeerTodos().Select(this.CrearViewModelDeDataView).ToList();
        }

        public ComisionVM LeerPorID(int ID)
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

        public override void Registrar(ComisionVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(ComisionVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(ComisionVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }
        #endregion

        #region Funciones de Conversion

        private readonly Func<ComisionDataView, ComisionVM> CrearViewModelDeDataView = e =>
        {
            var vm = new ComisionVM();
            vm.ID = e.ID;
            vm.Descripcion = e.Descripcion;
            vm.AnioEspecialidad = e.AnioEspecialidad;
            vm.PlanID = e.PlanID;
            vm.PlanDescripcion = e.PlanDescripcion;

            return vm;
        };

        private readonly Func<ComisionVM, ComisionDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new ComisionDataView();
            dv.ID = e.ID;
            dv.Descripcion = e.Descripcion;
            dv.AnioEspecialidad = e.AnioEspecialidad;
            dv.PlanID = e.PlanID;
            dv.PlanDescripcion = e.PlanDescripcion;

            return dv;
        };

        #endregion

    }
}
