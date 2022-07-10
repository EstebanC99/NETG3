using Business.Logic.Interfaces;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ApplicationForm;

namespace Academia.UI.WindowsForms
{
    public partial class Alumnos : Form
    {
        private IAlumnoLogic Logic { get; set; }

        public Alumnos()
        {
            InitializeComponent();
        }

        public Alumnos(IAlumnoLogic alumnoLogic)
        {
            InitializeComponent();
            this.Logic = alumnoLogic;
            this.dgvAlumnos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvAlumnos.DataSource = this.Logic.GetAll();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoDesktop alumnoDesktop = new AlumnoDesktop(ModoForm.Alta, this.Logic);

            alumnoDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count == 0) return;

            AlumnoDesktop alumnoDesktop = new AlumnoDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Modificacion, this.Logic);

            alumnoDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count == 0) return;

            AlumnoDesktop alumnoDesktop = new AlumnoDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Baja, this.Logic);

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
