using Academia.UI.Services;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Planes : FormAdministracionBase<IPlanUIService>
    {
        public Planes()
        {

        }
        public Planes(IPlanUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvPlanes.AutoGenerateColumns = false;

            this.DesactivarMenuTsb(this.tsPlanes);
        }

        public void Listar()
        {
            this.dgvPlanes.DataSource = this.UIService.LeerTodos();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanesDesktop planesDesktop = new PlanesDesktop(this.UIService, ModoForm.Alta);

            planesDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count == 0) return;

            PlanesDesktop planesDesktop = new PlanesDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            planesDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count == 0) return;

            PlanesDesktop planesDesktop = new PlanesDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            planesDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvPlanes.SelectedRows[0].Cells[0].Value;
        }
    }
}

