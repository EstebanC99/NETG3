namespace Academia.UI.Globals
{
    public static class RolesUsuario
    {
        public const int Alumno = (int)RolUsuario.Alumno;
        public const int Profesor = (int)RolUsuario.Profesor;
        public const int Administrador = (int)RolUsuario.Administrador;

        public enum RolUsuario
        {
            Alumno = 1,
            Profesor = 2,
            Administrador = 100
        }
    }
}
