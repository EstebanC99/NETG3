using Academia.UI.ViewModels;
using Business.Logic;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services
{
    public class UsuarioUIService : UIService<IUsuarioLogic, UsuarioVM>, IUsuarioUIService
    {
        private IRolLogic RolLogic { get; set; }

        public UsuarioUIService(IUsuarioLogic logic,
                                IRolLogic rolLogic) : base(logic)
        {
            this.RolLogic = rolLogic;
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

        public List<ViewModel> LeerRoles()
        {
            return this.RolLogic.GetAll().ConvertAll<ViewModel>(p => new ViewModel()
            {
                ID = p.ID,
                Descripcion = p.Descripcion
            });
        }

        #region Funciones de Conversion

        private readonly Func<UsuarioDataView, UsuarioVM> CrearViewModelDeDataView = e =>
        {
            var vm = new UsuarioVM();

            vm.ID = e.ID;
            vm.PersonaID = e.PersonaID;
            vm.Nombre = e.PersonaNombre;
            vm.Apellido = e.PersonaApellido;
            vm.NombreUsuario = e.NombreUsuario;
            vm.Clave = e.Clave;
            vm.Habilitado = e.Habilitado;
            vm.Email = e.PersonaEmail;
            vm.CambiaClave = e.CambiaClave;

            return vm;
        };

        private readonly Func<UsuarioVM, UsuarioDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new UsuarioDataView();

            dv.ID = e.ID;
            dv.PersonaID = e.PersonaID;
            dv.NombreUsuario = e.NombreUsuario;
            dv.Clave = e.Clave;
            dv.Habilitado = e.Habilitado;
            dv.CambiaClave = e.CambiaClave;

            return dv;
        };

        #endregion
    }
}
