using System.Collections.Generic;

namespace Academia.UI.ViewModels
{
    public class ReportePlanesVM : ViewModel
    {
        public ReportePlanesVM()
        {
            this.Materias = new List<ReportePlanesMateriaItemVM>();
            this.Alumnos = new List<ReportePlanesAlumnoItemVM>();
            this.Comisiones = new List<ReportePlanesComisionItemVM>();
        }

        public string EspecialidadDescripcion { get; set; }

        public List<ReportePlanesMateriaItemVM> Materias { get; set; }

        public List<ReportePlanesAlumnoItemVM> Alumnos { get; set; }

        public List<ReportePlanesComisionItemVM> Comisiones { get; set; }
    }
}
