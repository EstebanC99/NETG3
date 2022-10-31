using Academia.UI.Services;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Profesores : FormAdministracionBase<IProfesorUIService>
    {
        public Profesores(IProfesorUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvProfesores.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvProfesores.DataSource = this.UIService.LeerTodos();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ProfesorDesktop profesorDesktop = new ProfesorDesktop(this.UIService, ModoForm.Alta);

            profesorDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvProfesores.SelectedRows.Count == 0) return;

            ProfesorDesktop profesorDesktop = new ProfesorDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            profesorDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvProfesores.SelectedRows.Count == 0) return;

            ProfesorDesktop profesorDesktop = new ProfesorDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            profesorDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvProfesores.SelectedRows[0].Cells[0].Value;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
