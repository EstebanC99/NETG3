using Business.Logic.Interfaces;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ApplicationForm;

namespace Academia.UI.WindowsForms
{
    public partial class Profesores : Form
    {
        private IProfesorLogic Logic { get; set; }

        public Profesores(IProfesorLogic profesorLogic)
        {
            InitializeComponent();
            this.Logic = profesorLogic;
            this.dgvProfesores.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvProfesores.DataSource = this.Logic.GetAll();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ProfesorDesktop profesorDesktop = new ProfesorDesktop(ModoForm.Alta, this.Logic);

            profesorDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvProfesores.SelectedRows.Count == 0) return;

            ProfesorDesktop profesorDesktop = new ProfesorDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Modificacion, this.Logic);

            profesorDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvProfesores.SelectedRows.Count == 0) return;

            ProfesorDesktop profesorDesktop = new ProfesorDesktop(this.ObtenerItemSeleccionadoID(), ModoForm.Baja, this.Logic);

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
