using static Business.Entities.Global.TiposPersonas;

namespace Business.Entities
{
    public class Profesor : Persona
    {
        public override int TipoPersona { get { return (int)TiposPersona.Profesor; } }

        public override void Validar() { }
    }
}
