using Academia.UI.ViewModels;
using Business.Logic;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services
{
    public class UsuarioUIService : UIService<IUsuarioLogic, UsuarioVM>, IUsuarioUIService
    {
        public UsuarioUIService(IUsuarioLogic logic) : base(logic)
        {

        }

        public UsuarioVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID(ID));
        }

        public List<UsuarioVM> LeerTodos()
        {
            return this.Logic.LeerTodos().Select(this.CrearViewModelDeDataView).ToList();
        }

        public override void Registrar(UsuarioVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(UsuarioVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(UsuarioVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }

        #region Funciones de Conversion

        private readonly Func<UsuarioDataView, UsuarioVM> CrearViewModelDeDataView = e =>
        {
            var vm = new UsuarioVM();

            vm.ID = e.ID;
            vm.Nombre = e.Nombre;
            vm.Apellido = e.Apellido;
            vm.NombreUsuario = e.NombreUsuario;
            vm.Clave = e.Clave;
            vm.Habilitado = e.Habilitado;
            vm.Email = e.Email;
            vm.CambiaClave = e.CambiaClave;

            return vm;
        };

        private readonly Func<UsuarioVM, UsuarioDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new UsuarioDataView();

            dv.ID = e.ID;
            dv.Nombre = e.Nombre;
            dv.Apellido = e.Apellido;
            dv.NombreUsuario = e.NombreUsuario;
            dv.Clave = e.Clave;
            dv.Habilitado = e.Habilitado;
            dv.Email = e.Email;
            dv.CambiaClave = e.CambiaClave;

            return dv;
        };

        #endregion
    }
}
