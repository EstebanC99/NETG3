using Academia.UI.Services.Materias;
using Academia.UI.ViewModels;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class MateriaDesktop : ApplicationForm<IMateriaUIService, MateriaVM>
    {
        public MateriaDesktop()
        {
        }

        public MateriaDesktop(IMateriaUIService uiService, ModoForm modo) : base(uiService, modo)
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

            this.comboPlanes.SelectedItem = this.comboPlanes.Items[0];
        }

        public MateriaDesktop(int materiaID, IMateriaUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(materiaID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposRequeridos.Add(this.txtDescripcion);
            this.CamposNumericosRequeridos.Add(this.txtHsSemanales);
            this.CamposNumericosRequeridos.Add(this.txtHsTotales);

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
            this.Model.HsSemanales = int.Parse(this.txtHsSemanales.Text);
            this.Model.HsTotales = int.Parse(this.txtHsTotales.Text);
            this.Model.PlanID = ((PlanVM)this.comboPlanes.SelectedItem).ID;
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.Model.ID.ToString();
            this.txtDescripcion.Text = this.Model.Descripcion;
            this.txtHsSemanales.Text = this.Model.HsSemanales.ToString();
            this.txtHsTotales.Text = this.Model.HsTotales.ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
