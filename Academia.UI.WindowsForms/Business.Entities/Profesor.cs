using Cross.Exceptions;
using System.Collections.Generic;
using System.Linq;
using static Business.Entities.Global.TiposPersonas;

namespace Business.Entities
{
    public class Profesor : Persona
    {
        public Profesor() : base()
        {
            this.CursosACargo = new List<DocenteCurso>();
        }

        public override int TipoPersona
        {
            get { return (int)TiposPersona.Profesor; }
        }

        public void AsignarCurso(Curso curso, string cargo)
        {
            var validaciones = new ValidationException();

            if (curso == null)
            {
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(Curso)));
            }

            if (string.IsNullOrEmpty(cargo))
            {
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(DocenteCurso.Cargo)));
            }

            validaciones.Throw();

            if (this.CursosACargo.Any(c => c.Curso.ID == curso.ID))
            {
                throw new ValidationException(string.Format(Messages.ElProfesorYaSeEncuentraAsignadoAlCursoConElCargo, this.Apellido, cargo));
            }

            var cursoACargo = new DocenteCurso();

            cursoACargo.Curso = curso;
            cursoACargo.Profesor = this;
            cursoACargo.Cargo = cargo;

            this.CursosACargo.Add(cursoACargo);
        }

        public void EliminarCurso(Curso curso)
        {
            var cursoACargo = this.CursosACargo.FirstOrDefault(c => c.Curso.ID == curso.ID);

            if (cursoACargo == null)
                return;

            this.CursosACargo.Remove(cursoACargo);
        }
    }
}
