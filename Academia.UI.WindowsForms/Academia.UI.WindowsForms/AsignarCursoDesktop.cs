using Academia.UI.Services.Academicos.AsignacionCurso;
using Academia.UI.ViewModels;
using Business.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class AsignarCursoDesktop : Form
    {
        private IAsignarCursoUIService AsignarCursoUIService { get; set; }

        private List<ProfesorCursoVM> ProfesoresCurso { get; set; }

        private CursoVM CursoElegido { get; set; }

        private AsignarCursoDesktop(IAsignarCursoUIService asignarCursoUIService)
        {
            this.AsignarCursoUIService = asignarCursoUIService;
        }

        public AsignarCursoDesktop() : this(IoCContainer.Instance.TryResolve<IAsignarCursoUIService>())
        {
            InitializeComponent();

            this.dgCursos.AutoGenerateColumns = false;
            this.dgProfesoresAsignados.AutoGenerateColumns = false;

            this.dgCursos.DataSource = this.AsignarCursoUIService.LeerCursos();
        }

        private void dgCursos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgCursos.SelectedRows.Count == default(int))
                return;

            this.CursoElegido = (CursoVM)this.dgCursos.SelectedRows[0].DataBoundItem;

            this.ActualizarProfesores();
        }

        public void RecuperarProfesorElegido(ProfesorCursoVM profesorCursoVM)
        {
            this.AsignarCursoUIService.AsignarCurso(profesorCursoVM);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            this.AgregarProfesor();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            var profesor = (ProfesorCursoVM)this.dgProfesoresAsignados.SelectedRows[0].DataBoundItem;

            var respuesta = MessageBox.Show(string.Format("¿Seguro desea eliminar al profesor {0} del curso?", profesor.ProfesorApellido), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                profesor.ID = this.CursoElegido.ID;

                this.AsignarCursoUIService.EliminarCurso(profesor);

                MessageBox.Show("Eliminado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.ActualizarProfesores();

            return;
        }

        private void AgregarProfesor()
        {
            using (var profesoresList = new ProfesoresList(this.CursoElegido))
            {
                profesoresList.ShowDialog(this);
            }

            this.ActualizarProfesores();
        }

        private void dgProfesoresAsignados_DataSourceChanged(object sender, System.EventArgs e)
        {
            this.btnEliminar.Enabled = this.dgProfesoresAsignados.Rows.Count > default(int) && 
                                       this.dgProfesoresAsignados.SelectedRows.Count > default(int);
        }

        private void dgCursos_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.AgregarProfesor();
            }
        }

        private void ActualizarProfesores()
        {
            this.ProfesoresCurso = this.AsignarCursoUIService.LeerProfesoresPorCurso(this.CursoElegido.ID);

            this.dgProfesoresAsignados.DataSource = this.ProfesoresCurso;
        }
    }
}
