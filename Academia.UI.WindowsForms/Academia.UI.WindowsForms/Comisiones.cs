using Academia.UI.Services;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Comisiones : FormAdministracionBase<IComisionUIService>
    {
        public Comisiones()
        {
            InitializeComponent();
        }

        public Comisiones(IComisionUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvComisiones.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvComisiones.DataSource = this.UIService.LeerTodos();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionesDesktop comisionesDesktop = new ComisionesDesktop(this.UIService, ModoForm.Alta);

            comisionesDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count == 0) return;

            ComisionesDesktop comisionesDesktop = new ComisionesDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            comisionesDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count == 0) return;

            ComisionesDesktop comisionesDesktop = new ComisionesDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            comisionesDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvComisiones.SelectedRows[0].Cells[0].Value;
        }
    }
}
