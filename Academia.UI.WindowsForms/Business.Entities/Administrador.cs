using static Business.Entities.Global.TiposPersonas;

namespace Business.Entities
{
    public class Administrador : Persona
    {
        public override int TipoPersona { get { return (int)TiposPersona.Administrador; } }
    }
}
