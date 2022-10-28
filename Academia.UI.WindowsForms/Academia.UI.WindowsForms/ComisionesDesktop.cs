using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class ComisionesDesktop : ApplicationForm<IComisionUIService, ComisionVM>
    {
        public ComisionesDesktop()
        {

        }

        public ComisionesDesktop(IComisionUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.comboPlanes.Items.Clear();
            this.comboPlanes.DisplayMember = nameof(this.Model.Descripcion);
            this.comboPlanes.ValueMember = nameof(this.Model.ID);

            foreach (var item in this.UIService.LeerPlanes())
            {
                this.comboPlanes.Items.Add(item);
            }

            if (this.comboPlanes.Items.Count > default(int))
                this.comboPlanes.SelectedItem = this.comboPlanes.Items[0];
        }

        public ComisionesDesktop(int comisionID, IComisionUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(comisionID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposRequeridos.Add(this.txtDescripcion);

            if (this.Validar())
            {
                this.MapearADatos();

                this.GuardarCambios();

                this.Close();
            }
        }

        protected override void MapearADatos()
        {
            this.Model.Descripcion = this.txtDescripcion.Text;
            this.Model.AnioEspecialidad = int.Parse(this.txtAnioEspecialidad.Text);
            this.Model.PlanID = ((PlanVM)this.comboPlanes.SelectedItem).ID;
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.Model.ID.ToString();
            this.txtDescripcion.Text = this.Model.Descripcion;
            this.txtAnioEspecialidad.Text = this.Model.AnioEspecialidad.ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMas_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txtAnioEspecialidad.Text) < 5)
                this.txtAnioEspecialidad.Text = (int.Parse(this.txtAnioEspecialidad.Text) + 1).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txtAnioEspecialidad.Text) > 1)
                this.txtAnioEspecialidad.Text = (int.Parse(this.txtAnioEspecialidad.Text) - 1).ToString();
        }
    }
}
