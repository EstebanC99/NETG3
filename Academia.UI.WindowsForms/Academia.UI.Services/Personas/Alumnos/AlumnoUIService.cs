using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services
{
    public class AlumnoUIService : UIService<IAlumnoLogic, AlumnoVM>, IAlumnoUIService
    {
        public AlumnoUIService(IAlumnoLogic logic) : base(logic)
        {

        }

        public AlumnoVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID<AlumnoDataView>(ID));
        }

        public List<AlumnoVM> LeerTodos()
        {
            return this.Logic.LeerTodos<AlumnoDataView>().Select(this.CrearViewModelDeDataView).ToList();
        }

        public override void Registrar(AlumnoVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(AlumnoVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(AlumnoVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }

        #region Funciones de Conversion

        private readonly Func<AlumnoDataView, AlumnoVM> CrearViewModelDeDataView = e =>
        {
            var vm = new AlumnoVM();

            vm.ID = e.ID;
            vm.Nombre = e.Nombre;
            vm.Apellido = e.Apellido;
            vm.Legajo = e.Legajo;
            vm.Direccion = e.Direccion;
            vm.Telefono = e.Telefono;
            vm.Email = e.Email;
            vm.FechaNacimiento = e.FechaNacimiento;
            vm.PlanID = e.PlanID;
            vm.PlanDescripcion = e.PlanDescripcion;

            return vm;
        };

        private readonly Func<AlumnoVM, AlumnoDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new AlumnoDataView();

            dv.ID = e.ID;
            dv.Nombre = e.Nombre;
            dv.Apellido = e.Apellido;
            dv.Legajo = e.Legajo;
            dv.Direccion = e.Direccion;
            dv.Telefono = e.Telefono;
            dv.Email = e.Email;
            dv.FechaNacimiento = e.FechaNacimiento;
            dv.PlanID = e.PlanID;
            dv.PlanDescripcion = e.PlanDescripcion;

            return dv;
        };

        #endregion

    }
}
