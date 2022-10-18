using Business.Entities;
using Business.Views.Cursos;
using EntityFramework.DbContextScope.Interfaces;
using System.Linq;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public class IngresarNotaRepository : Repository, IIngresarNotaRepository
    {
        public IngresarNotaRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }

        public InscripcionDataView LeerInscripcionPorID(int inscripcionID)
        {
            var inscripcion = this.DbContext.Set<AlumnoInscripcion>()
                                  .FirstOrDefault(i => i.ID == inscripcionID);

            if (inscripcion == null)
                return null;

            return new InscripcionDataView()
            {
                ID = inscripcion.ID,
                AlumnoID = inscripcion.Alumno.ID,
                AlumnoNombre = inscripcion.Alumno.Nombre,
                AlumnoApellido = inscripcion.Alumno.Apellido,
                AlumnoLegajo = inscripcion.Alumno.Legajo,
                CursoID = inscripcion.Curso.ID,
                MateriaDescripcion = inscripcion.Curso.Materia.Descripcion,
                AnioCalendario = inscripcion.Curso.AnioCalendario,
                Nota = inscripcion.Nota
            };
        }
    }
}
