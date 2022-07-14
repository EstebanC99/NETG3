namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _IdPlan;    
        public int IdPlan
        {
            get { return this._IdPlan; }
            set { this._IdPlan = value; }
        }

        private int _AnioEspecialidad;
        public int AnioEspecialidad
        {
            get { return this._AnioEspecialidad; }
            set { this._AnioEspecialidad = value; }
        }

        
    }
}
