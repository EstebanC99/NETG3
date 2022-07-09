using Business.Logic.Interfaces;
using System;
using System.Windows.Forms;

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
    }
}
