using Academia.UI.Services;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Especialidades : FormAdministracionBase<IEspecialidadUIService>
    {
        public Especialidades()
        {

        }

        public Especialidades(IEspecialidadUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvEspecialidades.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvEspecialidades.DataSource = this.UIService.LeerTodos();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(this.UIService, ModoForm.Alta);

            especialidadDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count == 0) return;

            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            especialidadDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count == 0) return;

            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            especialidadDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvEspecialidades.SelectedRows[0].Cells[0].Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
