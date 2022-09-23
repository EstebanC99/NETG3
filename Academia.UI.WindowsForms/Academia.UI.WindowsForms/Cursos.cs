using Academia.UI.Globals;
using Academia.UI.Services;
using System;
using System.Collections.Generic;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Cursos : FormAdministracionBase<ICursoUIService>
    {
        public Cursos()
        {
            InitializeComponent();
        }

        public Cursos(ICursoUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvCursos.AutoGenerateColumns = false;

            this.DesactivarMenuTsb(this.tsPlanes);
        }

        public void Listar()
        {
            this.dgvCursos.DataSource = this.UIService.LeerTodos();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursosDesktop cursosDesktop = new CursosDesktop(this.UIService, ModoForm.Alta);

            cursosDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count == 0) return;

            CursosDesktop cursosDesktop = new CursosDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            cursosDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count == 0) return;

            CursosDesktop cursosDesktop = new CursosDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            cursosDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvCursos.SelectedRows[0].Cells[0].Value;
        }
    }
}
