namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public int ID_Persona_Profesor { get; set; }

        private Curso _Curso;
        public virtual Curso Curso
        {
            get { return this._Curso; }
            set { this._Curso = value; }
        }

        private Profesor _Profesor;
        public virtual Profesor Profesor
        {
            get { return this._Profesor; }
            set { this._Profesor = value; }
        }

        private string _Cargo;

        public string Cargo
        {
            get { return this._Cargo; }
            set { this._Cargo = value; }
        }

        
    }
}
