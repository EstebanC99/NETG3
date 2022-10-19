using System.Collections.Generic;

namespace Academia.UI.ViewModels
{
    public class ReporteCursoDetalleVM : ViewModel
    {
        public ReporteCursoDetalleVM()
        {
            this.Alumnos = new List<ReporteCursosAlumnoVM>();
        }

        public List<ReporteCursosAlumnoVM> Alumnos { get; set; }

        public int CantidadInscriptos { get; set; }

        public int CantidadAprobados { get; set; }

        public int CantidadRegulares { get; set; }

        public int CantidadLibres { get; set; }
    }
}
