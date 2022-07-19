using Academia.UI.ViewModels;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services
{
    public class CursoUIService : UIService<ICursoLogic, CursoVM>, ICursoUIService
    {
        public CursoUIService(ICursoLogic logic) : base(logic)
        {

        }

        public List<CursoVM> LeerTodos()
        {
            return this.Logic.LeerTodos().Select(this.CrearViewModelDeDataView).ToList();
        }

        public CursoVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID(ID));
        }

        public List<MateriaVM> LeerMaterias()
        {
            return this.Logic.LeerMaterias().ConvertAll(e => new MateriaVM()
            {
                ID = e.ID,
                Descripcion = e.Descripcion
            });
        }

        public List<ComisionVM> LeerComisiones()
        {
            return this.Logic.LeerComisiones().ConvertAll(e => new ComisionVM()
            {
                ID = e.ID,
                Descripcion = e.Descripcion
            });
        }

        #region Metodos de ABM

        public override void Registrar(CursoVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(CursoVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(CursoVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }
        #endregion

        #region Funciones de Conversion

        private readonly Func<CursoDataView, CursoVM> CrearViewModelDeDataView = e =>
        {
            var vm = new CursoVM();
            vm.ID = e.ID;
            vm.AnioCalendario = e.AnioCalendario;
            vm.Cupo = e.Cupo;
            vm.MateriaID = e.MateriaID;
            vm.MateriaDescripcion = e.MateriaDescripcion;
            vm.ComisionID = e.ComisionID;
            vm.ComisionDescripcion = e.ComisionDescripcion;

            return vm;
        };

        private readonly Func<CursoVM, CursoDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new CursoDataView();
            dv.ID = e.ID;
            dv.AnioCalendario = e.AnioCalendario;
            dv.Cupo = e.Cupo;
            dv.MateriaID = e.MateriaID;
            dv.MateriaDescripcion = e.MateriaDescripcion;
            dv.ComisionID = e.ComisionID;
            dv.ComisionDescripcion = e.ComisionDescripcion;

            return dv;
        };

        #endregion
    }
}
