using Business.Logic.Interfaces;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ApplicationForm;

namespace Academia.UI.WindowsForms
{
    public partial class Especialidades : Form
    {
        private IEspecialidadLogic Logic { get; set; }

        public Especialidades()
        {
            InitializeComponent();
        }

        public Especialidades(IEspecialidadLogic especialidadLogic)
        {
            InitializeComponent();
            this.Logic = especialidadLogic;
            this.dgvEspecialidades.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvEspecialidades.DataSource = this.Logic.GetAll();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ModoForm.Alta, this.Logic);

            especialidadDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count == 0) return;

            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Modificacion, this.Logic);

            especialidadDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count == 0) return;

            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Baja, this.Logic);

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
