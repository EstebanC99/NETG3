using Business.Criterias.Cursos;
using Business.Entities;
using Business.Views;
using EntityFramework.DbContextScope.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {

        }

        public List<CursoDataView> LeerCursosPorCriterio(CursoCriteria criteria)
        {
            var sp = "sp_LeerCursosPorCriterio";

            var cursosDataView = this.DbContext.Database.SqlQuery<CursoDataView>($"{sp} @pAnioCalendario, @pMateriaID, @pComisionID, @pAlumnoID",
                new SqlParameter("@pAnioCalendario", (object)criteria.AnioCalendario ?? DBNull.Value),
                new SqlParameter("@pMateriaID", (object)criteria.MateriaID ?? DBNull.Value),
                new SqlParameter("@pComisionID", (object)criteria.ComisionID ?? DBNull.Value),
                new SqlParameter("@pAlumnoID", (object)criteria.AlumnoID ?? DBNull.Value)
                ).ToList();

            foreach (var cursoDataView in cursosDataView)
            {
                var curso = this.GetByID(cursoDataView.ID);

                cursoDataView.CuposRestantes = curso.ObtenerCuposDisponibles();
            }

            return cursosDataView;
        }

        public List<AlumnoDataView> LeerAlumnosInscriptos(int cursoID)
        {
            var sp = "sp_LeerAlumnosInscriptosPorCurso";

            var alumnosDataView = this.DbContext.Database.SqlQuery<AlumnoDataView>($"{sp} @pCursoID",
                new SqlParameter("@pCursoID", (object)cursoID ?? DBNull.Value)
                ).ToList();

            return alumnosDataView;
        }
    }
}
