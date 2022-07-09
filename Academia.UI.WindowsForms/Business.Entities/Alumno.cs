using static Business.Entities.Global.TiposPersonas;

namespace Business.Entities
{
    public class Alumno : Persona
    {
        public override int TipoPersona { get { return (int)TiposPersona.Alumno; } }

        public override void Validar() { }
    }
}
