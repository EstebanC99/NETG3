using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.UI.ViewModels
{
    public class InscripcionVM: InscripcionCursoVM
    {
        public int? Nota { get; set; }

        public int AlumnoID { get; set; }

        public string AlumnoNombre { get; set; }

        public string AlumnoApellido { get; set; }

        public int? AlumnoLegajo { get; set; }

        public string MateriaDescripcion { get; set; }

        public int AnioCalendario { get; set; }
    }
}
