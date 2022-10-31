using Academia.UI.Services;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Alumnos : FormAdministracionBase<IAlumnoUIService>
    {
        public Alumnos(IAlumnoUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvAlumnos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvAlumnos.DataSource = this.UIService.LeerTodos();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoDesktop alumnoDesktop = new AlumnoDesktop(this.UIService, ModoForm.Alta);

            alumnoDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count == 0) return;

            AlumnoDesktop alumnoDesktop = new AlumnoDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            alumnoDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count == 0) return;

            AlumnoDesktop alumnoDesktop = new AlumnoDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            alumnoDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvAlumnos.SelectedRows[0].Cells[0].Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
