using Academia.UI.Globals;
using Academia.UI.Services.ReporteCursos;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Academia.UI.WindowsForms
{
    public partial class ReporteCursosForm : Form
    {
        private IReporteCursosUIService UIService { get; set; }

        private ReporteCursosFiltroVM Filtro { get; set; }

        private ReporteCursosForm(IReporteCursosUIService reporteCursosUIService)
        {
            this.UIService = reporteCursosUIService;

            this.Filtro = new ReporteCursosFiltroVM();

            InitializeComponent();

            this.dgCursos.AutoGenerateColumns = false;
            this.dgAlumnosCurso.AutoGenerateColumns = false;

            this.Buscar();
        }

        public ReporteCursosForm() : this(IoCContainer.Instance.TryResolve<IReporteCursosUIService>())
        {

        }

        private void txtMateriaDescrip_TextChanged(object sender, EventArgs e)
        {
            this.Filtro.MateriaDescripcion = this.txtMateriaDescrip.Text;
            this.Buscar();
        }

        private void txtPlanDescrip_TextChanged(object sender, EventArgs e)
        {
            this.Filtro.PlanDescripcion = this.txtPlanDescrip.Text;
            this.Buscar();
        }

        private void Buscar()
        {
            this.dgCursos.DataSource = this.UIService.LeerPorPatron(this.Filtro);
        }

        private void dgCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgCursos.SelectedRows.Count != default(int))
            {
                var cursoID = ((ReporteCursosItemVM)this.dgCursos.SelectedRows[0].DataBoundItem).ID;

                var detalle = this.UIService.LeerDetalleCurso(cursoID);

                this.dgAlumnosCurso.DataSource = detalle?.Alumnos;

                this.lblTotalAlumnos.Text = detalle.Alumnos.Count().ToString();

                this.chartCondiciones.Titles.Clear();
                this.chartCondiciones.Series.Clear();
                this.chartCondiciones.Titles.Add("Condiciones");
                this.chartCondiciones.Series.Add("Condiciones");
                this.chartCondiciones.Series["Condiciones"].ChartType = SeriesChartType.Pie;
                this.chartCondiciones.Series["Condiciones"].IsValueShownAsLabel = true;
                this.chartCondiciones.Series["Condiciones"].Points.DataBindXY(new List<string>() { Condiciones.Aprobado, Condiciones.Regular, Condiciones.Libre, Condiciones.Inscripto },
                                                                              new List<int>() { detalle.CantidadAprobados, detalle.CantidadRegulares, detalle.CantidadLibres, detalle.CantidadInscriptos });
                this.chartCondiciones.ChartAreas.FirstOrDefault().Area3DStyle.Enable3D = true;
            }
        }
    }
}
