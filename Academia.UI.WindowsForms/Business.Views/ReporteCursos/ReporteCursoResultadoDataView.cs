using System.Collections.Generic;

namespace Business.Views.ReporteCursos
{
    public class ReporteCursoResultadoDataView : DataView
    {
        public ReporteCursoResultadoDataView()
        {
            this.Alumnos = new List<ReporteCursoAlumnoDataView>();
        }

        public List<ReporteCursoAlumnoDataView> Alumnos { get; set; }

        public int CantidadInscriptos { get; set; }

        public int CantidadAprobados { get; set; }

        public int CantidadRegulares { get; set; }

        public int CantidadLibres { get; set; }
    }
}
