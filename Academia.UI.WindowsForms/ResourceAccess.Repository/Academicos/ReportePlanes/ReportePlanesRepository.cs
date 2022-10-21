using Business.Criterias;
using Business.Entities;
using Business.Views.ReportePlanes;
using EntityFramework.DbContextScope.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ResourceAccess.Repository.Academicos.ReportePlanes
{
    public class ReportePlanesRepository : Repository<Plan>, IReportePlanesRepository
    {
        public ReportePlanesRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        public List<ReportePlanesDataView> LeerPorCriterio(ReportePlanesCriteria criteria)
        {
            var planes = this.DbSet.ToList();

            if (!string.IsNullOrEmpty(criteria.PlanDescripcion))
                planes = planes.Where(p => p.Descripcion.ToUpper().Contains(criteria.PlanDescripcion.ToUpper())).ToList();

            if (!string.IsNullOrEmpty(criteria.EspecialidadDescripcion))
                planes = planes.Where(p => p.Especialidad.Descripcion.ToUpper().Contains(criteria.EspecialidadDescripcion.ToUpper())).ToList();

            var planesDataView = new List<ReportePlanesDataView>();

            if (planes.Any())
            {

                foreach (var plan in planes)
                {
                    var materias = this.DbContext.Set<Materia>().Where(m => m.Plan.ID == plan.ID).ToList();

                    var alumnos = this.DbContext.Set<Alumno>().Where(a => a.Plan.ID == plan.ID).ToList();

                    var comisiones = this.DbContext.Set<Comision>().Where(c => c.Plan.ID == plan.ID).ToList();

                    planesDataView.Add(this.MapearPlanADataView(plan, materias, alumnos, comisiones));
                }
            }

            return planesDataView;
        }

        private ReportePlanesDataView MapearPlanADataView(Plan plan,
                                                          List<Materia> materias,
                                                          List<Alumno> alumnos,
                                                          List<Comision> comisiones)
        {
            return new ReportePlanesDataView
            {
                ID = plan.ID,
                Descripcion = plan.Descripcion,
                EspecialidadDescripcion = plan.Especialidad.Descripcion,
                Materias = materias.ConvertAll<ReportePlanesMateriaItemDataView>(m => new ReportePlanesMateriaItemDataView
                {
                    MateriaID = m.ID,
                    MateriaDescripcion = m.Descripcion,
                    HsSemanales = m.HsSemanales,
                    HsTotales = m.HsTotales
                }),
                Alumno = alumnos.ConvertAll<ReportePlanesAlumnoItemDataView>(a => new ReportePlanesAlumnoItemDataView
                {
                    AlumnoID = a.ID,
                    AlumnoNombre = a.Nombre,
                    AlumnoApellido = a.Apellido,
                    AlumnoLegajo = a.Legajo.Value,
                    AlumnoEmail = a.Email,
                    AlumnoTelefono = a.Telefono
                }),
                Comisiones = comisiones.ConvertAll<ReportePlanesComisionItemDataView>(c => new ReportePlanesComisionItemDataView
                {
                    ComisionID = c.ID,
                    ComisionDescripcion = c.Descripcion,
                    ComisionAnioEspecialidad = c.AnioEspecialidad,
                    ComisionCantAlumnos = this.DbContext.Set<AlumnoInscripcion>().Count(ai => ai.Curso.Comision.ID == c.ID)
                })
            };
        }
    }
}
