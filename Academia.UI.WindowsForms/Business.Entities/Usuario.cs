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

        private string _Nombre;
        public virtual string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        private string _Apellido;
        public virtual string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        private string _Email;
        public virtual string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
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
            get { return this._Habilitado; }
            set { this._CambiaClave = value; }
        }
    }
}
