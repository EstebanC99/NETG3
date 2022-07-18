using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class EspecialidadDesktop : ApplicationForm<IEspecialidadUIService, EspecialidadVM>
    {
        public EspecialidadDesktop()
        {

        }
        public EspecialidadDesktop(IEspecialidadUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);
        }

        public EspecialidadDesktop(int especialidadID, IEspecialidadUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(especialidadID);

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

