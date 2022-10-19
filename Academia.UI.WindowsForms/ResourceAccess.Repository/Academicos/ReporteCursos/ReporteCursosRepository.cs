using Business.Criterias;
using Business.Entities;
using Business.Entities.Global;
using Business.Views.ReporteCursos;
using EntityFramework.DbContextScope.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ResourceAccess.Repository.Academicos.ReporteCursos
{
    public class ReporteCursosRepository : Repository<Curso>, IReporteCursosRepository
    {
        public ReporteCursosRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }

        public List<ReporteCursosDataView> LeerPorPatron(ReporteCursosCriteria criteria)
        {
            var resultados = this.DbSet.OrderBy(c => c.Materia.Descripcion)
                                  .Select(c => new ReporteCursosDataView()
                                  {
                                      ID = c.ID,
                                      MateriaDescripcion = c.Materia.Descripcion,
                                      AnioCalendario = c.AnioCalendario,
                                      ComisionDescripcion = c.Comision.Descripcion,
                                      PlanDescripcion = c.Materia.Plan.Descripcion,
                                      EspecialidadDescripcion = c.Materia.Plan.Especialidad.Descripcion
                                  }).ToList();

            if (!string.IsNullOrEmpty(criteria.MateriaDescripcion))
                resultados = resultados.Where(c => c.MateriaDescripcion.ToUpper().Contains(criteria.MateriaDescripcion.ToUpper())).ToList();

            if (!string.IsNullOrEmpty(criteria.PlanDescripcion))
                resultados = resultados.Where(c => c.PlanDescripcion.ToUpper().Contains(criteria.PlanDescripcion.ToUpper())).ToList();
                                  
            return resultados;
        }

        public ReporteCursoResultadoDataView LeerDetalleCurso(int cursoID)
        {
            var sp = "sp_LeerAlumnosInscriptosPorCurso";

            var listaAlumnos = this.DbContext.Database.SqlQuery<ReporteCursoAlumnoDataView>($"{sp} @pCursoID",
                new SqlParameter("@pCursoID", (object)cursoID ?? DBNull.Value)).ToList();

            if (listaAlumnos != null)
            {
                var cursoDetalle = new ReporteCursoResultadoDataView()
                {
                    Alumnos = listaAlumnos,
                    CantidadInscriptos = listaAlumnos.Count(),
                    CantidadAprobados = listaAlumnos.Count(a => a.Condicion == Condiciones.Aprobado),
                    CantidadRegulares = listaAlumnos.Count(a => a.Condicion == Condiciones.Regular),
                    CantidadLibres = listaAlumnos.Count(a => a.Condicion == Condiciones.Libre)
                };

                return cursoDetalle;
            }

            return new ReporteCursoResultadoDataView();
        }
    }
}
