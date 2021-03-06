namespace Business.Views
{
    public class UsuarioDataView : DataView
    {
        public string NombreUsuario { get; set; }

        public string Clave { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public bool Habilitado { get; set; }

        public bool CambiaClave { get; set; }
    }
}
