using Business.Logic;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ApplicationForm;

namespace Academia.UI.WindowsForms
{
    public partial class Usuarios : Form
    {
        private IUsuarioLogic Logic { get; set; }

        public Usuarios(IUsuarioLogic logic)
        {
            InitializeComponent();
            this.Logic = logic;
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvUsuarios.DataSource = this.Logic.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ModoForm.Alta, this.Logic);

            usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0) return;

            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Modificacion, this.Logic);

            usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0) return;

            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Baja, this.Logic);

            usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvUsuarios.SelectedRows[0].Cells[0].Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
