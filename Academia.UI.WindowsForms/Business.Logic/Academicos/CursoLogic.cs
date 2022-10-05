using Business.Criterias.Cursos;
using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Academicos.Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic.Academicos
{
    public class CursoLogic : LogicBase<CursoDataView, Curso, ICursoRepository>, ICursoLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        private IComisionLogic ComisionLogic { get; set; }

        private IMateriaLogic MateriaLogic { get; set; }

        public CursoLogic(Curso entity,
                          ICursoRepository repository,
                          IDbContextScopeFactory dbContextScopeFactory,
                          IEntityLoaderLogicService entityLoaderLogicService,
                          IComisionLogic comisionLogic,
                          IMateriaLogic materiaLogic)
            : base(entity, repository, dbContextScopeFactory)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService;
            this.ComisionLogic = comisionLogic;
            this.MateriaLogic = materiaLogic;
        }

        public List<CursoDataView> LeerTodos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => new CursoDataView()
                {
                    ID = m.ID,
                    AnioCalendario = m.AnioCalendario,
                    Cupo = m.Cupo,
                    MateriaID = m.Materia.ID,
                    MateriaDescripcion = m.Materia.Descripcion,
                    ComisionID = m.Comision.ID,
                    ComisionDescripcion = m.Comision.Descripcion,
                    PlanID = m.Materia.Plan.ID,
                    PlanDescripcion = m.Materia.Plan.Descripcion,
                    EspecialidadID = m.Materia.Plan.Especialidad.ID,
                    EspecialidadDescripcion = m.Materia.Plan.Especialidad.Descripcion
                });
            }
        }

        public CursoDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new CursoDataView()
                {
                    ID = this.Entity.ID,
                    AnioCalendario = this.Entity.AnioCalendario,
                    Cupo = this.Entity.Cupo,
                    MateriaID = this.Entity.Materia.ID,
                    MateriaDescripcion = this.Entity.Materia.Descripcion,
                    ComisionID = this.Entity.Comision.ID,
                    ComisionDescripcion = this.Entity.Comision.Descripcion
                };
            }
        }

        public List<ComisionDataView> LeerComisiones()
        {
            return this.ComisionLogic.LeerTodos();
        }

        public List<MateriaDataView> LeerMaterias()
        {
            return this.MateriaLogic.LeerTodos();
        }

        public List<CursoDataView> LeerCursosPorCriterio(CursoCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.LeerCursosPorCriterio(criteria);
            }
        }

        #region Metodos Protegidos

        protected override void Mapear(CursoDataView curso)
        {
            this.Entity.AnioCalendario = curso.AnioCalendario;
            this.Entity.Cupo = curso.Cupo;

            this.Entity.Materia = this.EntityLoaderLogicService.GetByID<Materia>(curso.MateriaID);
            this.Entity.Comision = this.EntityLoaderLogicService.GetByID<Comision>(curso.ComisionID);
        }

        protected override void Validar(CursoDataView curso)
        {
            var validaciones = new ValidationException();

            if (curso.AnioCalendario == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, curso.AnioCalendario));

            if (curso.Cupo == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, curso.Cupo));

            if (curso.MateriaID == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, this.Entity.Materia));

            if (curso.ComisionID == default)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, this.Entity.Comision));

            validaciones.Throw();

            var comision = this.EntityLoaderLogicService.GetByID<Comision>(curso.ComisionID);
            var materia = this.EntityLoaderLogicService.GetByID<Materia>(curso.MateriaID);

            if (comision != null && materia != null && comision.Plan != materia.Plan)
                throw new ValidationException(string.Format(Messages.LaMateriaYLaComisionNoPertenecenAlMismoPlanX, materia.Plan.Descripcion));
        }

        #endregion
    }
}
