namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario;
        public int AnioCalendario
        {
            get { return this._AnioCalendario; }
            set { this._AnioCalendario = value; }
        }

        private int _Cupo;
        public int Cupo
        {
            get { return this._Cupo; }
            set { this._Cupo = value; }
        }

        private Comision _Comision;
        public virtual Comision Comision
        {
            get { return this._Comision; }
            set { this._Comision = value; }
        }

        private Materia _Materia;
        public virtual Materia Materia
        {
            get { return this._Materia; }
            set { this._Materia = value; }
        }

        
    }
}
