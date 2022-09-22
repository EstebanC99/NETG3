namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _NombreUsuario;
        public virtual string NombreUsuario
        {
            get { return this._NombreUsuario; }
            set { this._NombreUsuario = value; }
        }

        private string _Clave;
        public virtual string Clave
        {
            get { return this._Clave; }
            set { this._Clave = value; }
        }

        private bool _Habilitado;
        public virtual bool Habilitado
        {
            get { return this._Habilitado; }
            set { this._Habilitado = value; }
        }

        private bool _CambiaClave;
        public virtual bool CambiaClave
        {
            get { return this._CambiaClave; }
            set { this._CambiaClave = value; }
        }

        private Persona _Persona;
        public virtual Persona Persona
        {
            get { return this._Persona; }
            set { this._Persona = value; }
        }

        private Rol _Rol;
        public virtual Rol Rol
        {
            get { return this._Rol; }
            set { this._Rol = value; }
        }
    }
}
