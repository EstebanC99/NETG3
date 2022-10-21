using Academia.UI.Services.ReportePlanes;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class ReportePlanesForm : Form
    {
        private IReportePlanesUIService UIService { get; set; }

        private ReportePlanesFiltroVM Filtro { get; set; }

        private List<ReportePlanesVM> Resultado { get; set; }

        private ReportePlanesForm(IReportePlanesUIService uiService)
        {
            this.UIService = uiService;
            this.Filtro = new ReportePlanesFiltroVM();
            this.Resultado = new List<ReportePlanesVM>();

            InitializeComponent();

            this.dgPlanes.AutoGenerateColumns = false;
            this.dgMateriasPlan.AutoGenerateColumns = false;
            this.dgAlumnosPlan.AutoGenerateColumns = false;
            this.dgComisiones.AutoGenerateColumns = false;

            this.Buscar();
        }

        public ReportePlanesForm() : this(IoCContainer.Instance.TryResolve<IReportePlanesUIService>())
        {

        }

        private void Buscar()
        {
            this.Resultado = this.UIService.LeerPorCriterio(this.Filtro);

            this.dgPlanes.DataSource = this.Resultado;
        }

        private void filtroChanged(object sendet, EventArgs e)
        {
            this.Filtro.PlanDescripcion = this.txtPlanDescripcion.Text;
            this.Filtro.EspecialidadDescripcion = this.txtEspecialidadDescripcion.Text;

            this.Buscar();
        }

        private void PlanSelectionChanged(object sendet, EventArgs e)
        {
            var planID = this.GetSelectedPlanID();

            this.dgMateriasPlan.DataSource = this.Resultado.FirstOrDefault(r => r.ID == planID)?.Materias;
            this.dgAlumnosPlan.DataSource = this.Resultado.FirstOrDefault(r => r.ID == planID)?.Alumnos;
            this.dgComisiones.DataSource = this.Resultado.FirstOrDefault(r => r.ID == planID)?.Comisiones;
        }

        private void FiltroAlumnoChanged(object sender, EventArgs e)
        {
            var plan = this.Resultado.FirstOrDefault(p => p.ID == this.GetSelectedPlanID());

            var alumnoFiltro = this.txtAlumno.Text;

            this.dgAlumnosPlan.DataSource = plan?.Alumnos.Where(a => a.AlumnoNombre.ToUpper().Contains(alumnoFiltro.ToUpper())
                                                                 || a.AlumnoApellido.ToUpper().Contains(alumnoFiltro.ToUpper())
                                                                 || a.AlumnoLegajo.ToString().Contains(alumnoFiltro.ToUpper()))
                                                         .ToList();
        }

        private int? GetSelectedPlanID()
        {
            if (this.dgPlanes.SelectedRows.Count != default(int))
                return ((ReportePlanesVM)this.dgPlanes.SelectedRows[0].DataBoundItem).ID;
            
            return null;
        }
    }
}
