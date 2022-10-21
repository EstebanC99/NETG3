using System.Collections.Generic;

namespace Business.Views.ReportePlanes
{
    public class ReportePlanesDataView : DataView
    {
        public ReportePlanesDataView()
        {
            this.Materias = new List<ReportePlanesMateriaItemDataView>();
            this.Alumno = new List<ReportePlanesAlumnoItemDataView>();
            this.Comisiones = new List<ReportePlanesComisionItemDataView>();
        }

        public string EspecialidadDescripcion { get; set; }

        public List<ReportePlanesMateriaItemDataView> Materias { get; set; }

        public List<ReportePlanesAlumnoItemDataView> Alumno { get; set; }

        public List<ReportePlanesComisionItemDataView> Comisiones { get; set; }

    }
}
