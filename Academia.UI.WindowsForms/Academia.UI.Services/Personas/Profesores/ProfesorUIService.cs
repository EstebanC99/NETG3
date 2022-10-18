using Academia.UI.ViewModels;
using AutoMapper;
using Business.Logic.Interfaces;
using Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academia.UI.Services.Personas.Profesores
{
    public class ProfesorUIService : UIService<IProfesorLogic, ProfesorVM>, IProfesorUIService
    {
        public ProfesorUIService(IProfesorLogic logic) : base(logic)
        {

        }

        public ProfesorVM LeerPorID(int ID)
        {
            return this.CrearViewModelDeDataView(this.Logic.LeerPorID<ProfesorDataView>(ID));
        }

        public List<ProfesorVM> LeerTodos()
        {
            return this.Logic.LeerTodos<ProfesorDataView>().Select(this.CrearViewModelDeDataView).ToList();
        }

        public override void Registrar(ProfesorVM vm)
        {
            this.Logic.Registrar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Modificar(ProfesorVM vm)
        {
            this.Logic.Modificar(this.CrearDataViewDeViewModel(vm));
        }

        public override void Eliminar(ProfesorVM vm)
        {
            this.Logic.Eliminar(this.CrearDataViewDeViewModel(vm));
        }

        public List<CursoVM> LeerCursosPorProfesorLogueado()
        {
            var cursos = this.Logic.LeerCursosPorProfesorLogueado();

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<CursoDataView, CursoVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<CursoDataView>, List<CursoVM>>(cursos);
        }

        #region Funciones de Conversion

        private readonly Func<ProfesorDataView, ProfesorVM> CrearViewModelDeDataView = e =>
        {
            var vm = new ProfesorVM();

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

        private readonly Func<ProfesorVM, ProfesorDataView> CrearDataViewDeViewModel = e =>
        {
            var dv = new ProfesorDataView();

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
