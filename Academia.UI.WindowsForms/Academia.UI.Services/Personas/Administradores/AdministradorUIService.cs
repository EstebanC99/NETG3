using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views.Personas.Administradores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services.Personas.Administradores
{
    public class AdministradorUIService : UIService<IAdministradorLogic, AdministradorVM>, IAdministradorUIService
    {
        public AdministradorUIService(IAdministradorLogic logic) : base(logic)
        {

        }

        public AdministradorVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID<AdministradorDataView>(ID));
        }

        public List<AdministradorVM> LeerTodos()
        {
            return this.Logic.LeerTodos<AdministradorDataView>().Select(this.CrearViewModelDeDataView).ToList();
        }

        public override void Registrar(AdministradorVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(AdministradorVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(AdministradorVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }

        #region Funciones de Conversion

        private readonly Func<AdministradorDataView, AdministradorVM> CrearViewModelDeDataView = e =>
        {
            var vm = new AdministradorVM();

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

        private readonly Func<AdministradorVM, AdministradorDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new AdministradorDataView();

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
