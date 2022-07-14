namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private int _IdPlan;
        public int IdPlan
        {
            get { return this._IdPlan; }
            set { this._IdPlan = value; }
        }

        private int _HSSemanales;
        public int HSSemanales
        {
            get { return this._HSSemanales; }
            set { this._HSSemanales = value; }
        }

        private int _HSTotales;
        public int HSTotales
        {
            get { return this._HSTotales; }
            set { this._HSTotales = value; }
        }
    }
}
