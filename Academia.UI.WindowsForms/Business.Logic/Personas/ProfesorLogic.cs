using Business.Criterias.Personas;
using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using EntityFramework.DbContextScope;
using ResourceAccess.Repository.Personas;
using Security.Desktop;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic.Personas
{
    public class ProfesorLogic : PersonaLogic<Profesor, IProfesorRepository>, IProfesorLogic
    {
        private IUsuarioLogic UsuarioLogic { get; set; }

        public ProfesorLogic(Profesor entity,
                             IProfesorRepository repository,
                             DbContextScopeFactory dbContextScopeFactory,
                             IUsuarioLogic usuarioLogic)
            : base(entity, repository, dbContextScopeFactory)
        {
            this.UsuarioLogic = usuarioLogic;
        }

        public List<ProfesorDataView> BuscarPorCriteria(ProfesorCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.SearchByPattern(criteria);
            }
        }

        public List<CursoDataView> LeerCursosPorProfesorLogueado()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var profesor = this.Repository.GetByID(this.UsuarioLogic.LeerPorID(SessionInfo.Instance.UserID.Value).PersonaID);

                var cursosACargo = new List<CursoDataView>();

                if (profesor == null)
                    return cursosACargo;

                foreach (var curso in profesor.CursosACargo.Select(c => c.Curso))
                {
                    cursosACargo.Add(new CursoDataView()
                    {
                        ID = curso.ID,
                        MateriaID = curso.Materia.ID,
                        MateriaDescripcion = curso.Materia.Descripcion,
                        ComisionID = curso.Comision.ID,
                        ComisionDescripcion = curso.Comision.Descripcion,
                        PlanID = curso.Comision.Plan.ID,
                        PlanDescripcion = curso.Comision.Plan.Descripcion,
                        EspecialidadID = curso.Comision.Plan.Especialidad.ID,
                        EspecialidadDescripcion = curso.Comision.Plan.Especialidad.Descripcion,
                        AnioCalendario = curso.AnioCalendario
                    });
                }

                return cursosACargo;
            }
        }
    }
}
