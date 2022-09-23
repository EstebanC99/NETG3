namespace Academia.UI.Globals
{
    public static class TiposPersona
    {
        public const int Alumno = (int)TipoPersona.Alumno;

        public const int Profesor = (int)TipoPersona.Profesor;

        public const int Administrador = (int)TipoPersona.Administrador;

        public enum TipoPersona
        {
            Alumno = 1,
            Profesor = 2,
            Administrador = 100
        }
    }
}
