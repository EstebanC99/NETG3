using System.Collections.Generic;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        public Curso()
        {
            this.Inscriptos = new List<AlumnoInscripcion>();
        }

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


        private ICollection<AlumnoInscripcion> _Inscriptos;
        public virtual ICollection<AlumnoInscripcion> Inscriptos {
            get { return this._Inscriptos; } 
            set { this._Inscriptos = value; } 
        }

        public virtual int ObtenerCuposDisponibles()
        {
            return this.Cupo - this.Inscriptos.Count;
        }
    }
}
