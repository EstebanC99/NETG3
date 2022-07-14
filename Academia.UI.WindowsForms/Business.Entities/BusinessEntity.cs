namespace Business.Entities
{
    public abstract class BusinessEntity : IIdentificable
    {
        public BusinessEntity()
        {
            
        }

        private int _ID;
        public virtual int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }

        private string _Descripcion;
        public virtual string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }
    }
}
