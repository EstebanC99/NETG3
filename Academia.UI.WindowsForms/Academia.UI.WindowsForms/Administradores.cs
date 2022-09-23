using Academia.UI.Services.Personas.Administradores;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Administradores : FormAdministracionBase<IAdministradorUIService>
    {
        public Administradores(IAdministradorUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvAdministradores.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvAdministradores.DataSource = this.UIService.LeerTodos();
        }


        private void Administradores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AdministradorDesktop administradorDekstop = new AdministradorDesktop(this.UIService, ModoForm.Alta);

            administradorDekstop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAdministradores.SelectedRows.Count == 0) return;

            AdministradorDesktop administradorDekstop = new AdministradorDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            administradorDekstop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAdministradores.SelectedRows.Count == 0) return;

            AdministradorDesktop administradorDekstop = new AdministradorDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            administradorDekstop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvAdministradores.SelectedRows[0].Cells[0].Value;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
