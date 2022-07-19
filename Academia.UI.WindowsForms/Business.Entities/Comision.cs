namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private Plan _Plan;    
        public virtual Plan Plan
        {
            get { return this._Plan; }
            set { this._Plan = value; }
        }

        private int _AnioEspecialidad;
        public int AnioEspecialidad
        {
            get { return this._AnioEspecialidad; }
            set { this._AnioEspecialidad = value; }
        }

        
    }
}
