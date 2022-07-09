namespace Business.Entities
{
    public abstract class BusinessEntity : IIdentificable
    {
        public BusinessEntity()
        {
            
        }

        private int _ID;
        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }

        private States _State;
        public States State
        {
            get { return this._State; }
            set { this._State = value; }
        }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        public abstract void Validar();
    }
}
