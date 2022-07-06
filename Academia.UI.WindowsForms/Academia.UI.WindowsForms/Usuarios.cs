using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.WindowsForms
{
    public partial class Usuarios : Form
    {
        private IUsuarioLogic Logic { get; set; }

        public Usuarios(IUsuarioLogic logic)
        {
            InitializeComponent();
            this.Logic = logic;
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvUsuarios.DataSource = this.Logic.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            //UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            //
            //usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            //UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.ObtenerIDUsuarioSeleccionado(), ApplicationForm.ModoForm.Modificacion);
            //
            //usuarioDesktop.ShowDialog();

            this.Listar();
        }

        private int ObtenerIDUsuarioSeleccionado() 
        {
            if (this.dgvUsuarios.RowCount == 0 || this.dgvUsuarios.SelectedRows.Count <= 0)
                return 0;

            return ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //UsuarioDesktop usuarioDesktop = new UsuarioDesktop(this.ObtenerIDUsuarioSeleccionado(), ApplicationForm.ModoForm.Baja);
            //
            //usuarioDesktop.ShowDialog();

            this.Listar();
        }
    }
}
