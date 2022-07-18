using Academia.UI.Services.Materias;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class Materias : FormAdministracionBase<IMateriaUIService>
    {
        public Materias()
        {
            InitializeComponent();
        }

        public Materias(IMateriaUIService uiService) : base(uiService)
        {
            InitializeComponent();

            this.dgvMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvMaterias.DataSource = this.UIService.LeerTodos();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop materiaDesktop = new MateriaDesktop(this.UIService, ModoForm.Alta);

            materiaDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0) return;

            MateriaDesktop materiaDesktop = new MateriaDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Modificacion);

            materiaDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0) return;

            MateriaDesktop materiaDesktop = new MateriaDesktop(this.ObtenerItemSeleccionadoID(), this.UIService, ModoForm.Baja);

            materiaDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerItemSeleccionadoID()
        {
            return (int)this.dgvMaterias.SelectedRows[0].Cells[0].Value;
        }
    }
}
