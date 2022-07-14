using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class PlanesDesktop : ApplicationForm<IPlanUIService, PlanVM>
    {
        public PlanesDesktop()
        {

        }
        public PlanesDesktop(IPlanUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.comboEspecialidades.Items.Clear();
            this.comboEspecialidades.DisplayMember = nameof(this.Model.Descripcion);
            this.comboEspecialidades.ValueMember = nameof(this.Model.ID);

            foreach (var item in this.UIService.LeerEspecialidades())
            {
                this.comboEspecialidades.Items.Add(item);
            }

            this.comboEspecialidades.SelectedItem = this.comboEspecialidades.Items[0];
        }

        public PlanesDesktop(int planID, IPlanUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(planID);

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
            this.Model.ID = int.Parse(this.txtID.Text);
            this.Model.Descripcion = this.txtDescripcion.Text;
            this.Model.EspecialidadID = int.Parse(this.comboEspecialidades.SelectedItem.ToString());
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.Model.ID.ToString();
            this.txtDescripcion.Text = this.Model.Descripcion;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
