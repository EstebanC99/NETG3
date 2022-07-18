namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private int _HsSemanales;
        public int HsSemanales
        {
            get { return this._HsSemanales; }
            set { this._HsSemanales = value; }
        }

        private int _HsTotales;
        public int HsTotales
        {
            get { return this._HsTotales; }
            set { this._HsTotales = value; }
        }

        private Plan _Plan;
        public virtual Plan Plan
        {
            get { return this._Plan; }
            set { this._Plan = value; }
        }

    }
}
