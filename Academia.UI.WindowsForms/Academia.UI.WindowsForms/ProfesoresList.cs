using Academia.UI.Services.Academicos.AsignacionCurso;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class ProfesoresList : Form
    {
        private IAsignarCursoUIService UIService { get; set; }

        private CursoVM CursoElegido { get; set; }

        public ProfesoresList(IAsignarCursoUIService uiService)
        {
            InitializeComponent();

            this.UIService = uiService;

            this.dgProfesores.AutoGenerateColumns = false;
            this.dgProfesores.DataSource = this.UIService.LeerProfesorPorPatron(string.Empty);
        }

        public ProfesoresList(CursoVM cursoVM) : this(IoCContainer.Instance.TryResolve<IAsignarCursoUIService>())
        {
            this.CursoElegido = cursoVM;
        }

        private void dgPersonas_DoubleClick(object sender, EventArgs e)
        {
            this.ElegirProfesor();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            this.dgProfesores.DataSource = this.UIService.LeerProfesorPorPatron(this.txtNombreApellido.Text);
        }

        private void dgProfesores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ElegirProfesor();
            }
        }

        private void ElegirProfesor()
        {
            var asignarCursoDesktop = (AsignarCursoDesktop)this.Owner;

            var profesor = (ProfesorCursoVM)this.dgProfesores.SelectedRows[0].DataBoundItem;

            string cargo = "";
            var inputBox = InputBox.Create("Cargo del profesor", "Ingrese el cargo del profesor:", ref cargo);

            if (inputBox == DialogResult.OK && !string.IsNullOrEmpty(cargo))
            {
                profesor.Cargo = cargo;
                profesor.ID = this.CursoElegido.ID;

                asignarCursoDesktop.RecuperarProfesorElegido(profesor);

                this.Close();
            }
        }
    }
}
