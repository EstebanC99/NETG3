using Business.Entities.Global;
using Cross.Exceptions;
using System.Collections.Generic;
using System.Linq;
using static Business.Entities.Global.TiposPersonas;

namespace Business.Entities
{
    public class Alumno : Persona
    {
        public Alumno() : base()
        {
            this.Cursos = new List<AlumnoInscripcion>();
        }

        public override int TipoPersona { get { return (int)TiposPersona.Alumno; } }

        public void Inscribir(Curso curso)
        {
            if (curso.ObtenerCuposDisponibles() <= default(int))
            {
                throw new ValidationException("No hay mas cupos para le curso seleccionado!");
            }

            var alumnoInscripcion = new AlumnoInscripcion();

            alumnoInscripcion.Alumno = this;
            alumnoInscripcion.Curso = curso;
            alumnoInscripcion.Condicion = "Inscripto";

            this.Cursos.Add(alumnoInscripcion);
        }

        public void Desmatricularse(Curso curso)
        {
            var inscripcion = this.Cursos.FirstOrDefault(i => i.Curso.ID == curso.ID);

            if (inscripcion == null)
                return;

            if (inscripcion.Nota > default(int))
            {
                throw new ValidationException("Ya posee nota cargada!");
            }

            if (inscripcion.Condicion != Condiciones.Inscripto)
            {
                throw new ValidationException("La condicion no permite desmatricularse!");
            }

            this.Cursos.Remove(inscripcion);
        }

    }
}
