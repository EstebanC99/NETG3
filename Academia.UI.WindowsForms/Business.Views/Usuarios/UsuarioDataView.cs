namespace Business.Views
{
    public class UsuarioDataView : DataView
    {
        public string NombreUsuario { get; set; }

        public string Clave { get; set; }

        public int PersonaID { get; set; }

        public string PersonaNombre { get; set; }

        public string PersonaApellido { get; set; }

        public string PersonaEmail { get; set; }

        public bool Habilitado { get; set; }

        public bool? CambiaClave { get; set; }

        public int RolUsuarioID { get; set; }

        public string RolUsuarioDescripcion { get; set; }
    }
}
