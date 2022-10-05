using Business.Entities;
using Business.Views;
using Business.Views.AsignarCursos;
using EntityFramework.DbContextScope.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ResourceAccess.Repository.Academicos.AsignarCurso
{
    public class AsignarCursoRepository : Repository, IAsignarCursoRepository
    {
        public AsignarCursoRepository(IAmbientDbContextLocator ambienDbContextLocator)
            : base(ambienDbContextLocator)
        {

        }

        public List<ProfesorCursoDataView> LeerProfesoresPorCurso(int cursoID)
        {
            var docentes = this.DbContext.Set<DocenteCurso>().Where(d => d.Curso.ID == cursoID)
                                                     .ToList();

            if (docentes == null)
                return new List<ProfesorCursoDataView>();

            return docentes.ConvertAll<ProfesorCursoDataView>(d => new ProfesorCursoDataView()
            {
                ID = d.ID,
                ProfesorID = d.Profesor.ID,
                ProfesorNombre = d.Profesor.Nombre,
                ProfesorApellido = d.Profesor.Apellido,
                ProfesorLegajo = d.Profesor.Legajo,
                Cargo = d.Cargo
            });
        }
    }
}
