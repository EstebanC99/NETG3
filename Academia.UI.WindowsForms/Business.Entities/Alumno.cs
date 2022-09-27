using System.Collections.Generic;
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
            var alumnoInscripcion = new AlumnoInscripcion();

            alumnoInscripcion.Alumno = this;
            alumnoInscripcion.Curso = curso;
            alumnoInscripcion.Condicion = "Inscripto";

            this.Cursos.Add(alumnoInscripcion);
        }

    }
}
