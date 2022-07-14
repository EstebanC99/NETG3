using Academia.UI.Services;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Usuarios : FormAdministracionBase<IUsuarioUIService>
    {
        public Usuarios(IUsuarioUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvUsuarios.DataSource = this.UIService.LeerTodos();
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
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.UIService, ModoForm.Alta);

            usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0) return;

            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0) return;

            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

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
