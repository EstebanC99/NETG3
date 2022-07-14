namespace Business.Entities
{
    public class Plan : BusinessEntity
    { 
        private Especialidad _Especialidad;
        public virtual Especialidad Especialidad
        {
            get { return this._Especialidad; }
            set { this._Especialidad = value; }
        }

    }
}
