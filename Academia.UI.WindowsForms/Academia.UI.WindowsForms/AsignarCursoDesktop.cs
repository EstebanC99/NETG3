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

            this.ProfesoresCurso = this.AsignarCursoUIService.LeerProfesoresPorCurso(this.CursoElegido.ID);

            this.dgProfesoresAsignados.DataSource = this.ProfesoresCurso;
        }

        public void RecuperarProfesorElegido(ProfesorCursoVM profesorCursoVM)
        {
            this.AsignarCursoUIService.AsignarCurso(profesorCursoVM);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            using (var profesoresList = new ProfesoresList(this.CursoElegido))
            {
                profesoresList.ShowDialog(this);
            }
        }
    }
}
