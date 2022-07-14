using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope;
using ResourceAccess.Repository.Academicos;
using System.Collections.Generic;

namespace Business.Logic.Academicos
{
    public class EspecialidadLogic : LogicBase<EspecialidadDataView, Especialidad, IEspecialidadRepository>, IEspecialidadLogic
    {
        public EspecialidadLogic(Especialidad entity, IEspecialidadRepository repository, DbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

        public EspecialidadDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity =  this.Repository.GetByID(ID);
                return new EspecialidadDataView()
                {
                    ID = this.Entity.ID,
                    Descripcion = this.Entity.Descripcion
                };
            }
        }

        public List<EspecialidadDataView> LeerTodos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => 
                new EspecialidadDataView()
                {
                    ID = m.ID,
                    Descripcion = m.Descripcion
                });
            }
        }

        #region Metodos Protegidos

        protected override void Mapear(EspecialidadDataView especialidad)
        {
            this.Entity.Descripcion = especialidad.Descripcion;
        }

        protected override void Validar(EspecialidadDataView especialidad)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(especialidad.Descripcion))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, especialidad.Descripcion));

            validaciones.Throw();
        }

        #endregion
    }
}
