namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public int ID_Persona_Alumno { get; set; }

        public int ID_Curso { get; set; }
        
        private string _Condicion;
        public string Condicion
        {
            get { return this._Condicion; }
            set { this._Condicion = value; }
        }

        private Alumno _Alumno;
        public virtual Alumno Alumno
        {
            get { return this._Alumno; }
            set { this._Alumno = value; }
        }

        private Curso _Curso;
        public virtual Curso Curso
        {
            get { return this._Curso; }
            set { this._Curso = value; }
        }

        private int _Nota;
        public int Nota
        {
            get { return this._Nota; }
            set { this._Nota = value; }
        }
    }
}
