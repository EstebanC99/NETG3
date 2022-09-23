using Academia.UI.Services.Personas.Administradores;
using Academia.UI.ViewModels;
using System;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class AdministradorDesktop : ApplicationForm<IAdministradorUIService, AdministradorVM>
    {
        public AdministradorDesktop()
        {

        }

        public AdministradorDesktop(IAdministradorUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);
        }

        public AdministradorDesktop(int administradorID, IAdministradorUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(administradorID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposRequeridos.Add(this.txtNombre);
            this.CamposRequeridos.Add(this.txtApellido);
            this.CamposNumericosRequeridos.Add(this.txtLegajo);

            if (this.Validar())
            {
                this.MapearADatos();

                this.GuardarCambios();

                this.Close();
            }
        }

        protected override void MapearADatos()
        {
            this.Model.Nombre = this.txtNombre.Text;
            this.Model.Apellido = this.txtApellido.Text;
            this.Model.Email = this.txtEmail.Text;
            this.Model.Direccion = this.txtDireccion.Text;
            this.Model.Telefono = this.txtTelefono.Text;
            this.Model.Legajo = int.Parse(this.txtLegajo.Text);
            this.Model.FechaNacimiento = this.dtFechaNacimiento.Value.Date;
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.Model.ID.ToString();
            this.txtNombre.Text = this.Model.Nombre;
            this.txtApellido.Text = this.Model.Apellido;
            this.txtEmail.Text = this.Model.Email;
            this.txtLegajo.Text = this.Model.Legajo.ToString();
            this.txtDireccion.Text = this.Model.Direccion;
            this.txtTelefono.Text = this.Model.Telefono;
            this.dtFechaNacimiento.Value = this.Model.FechaNacimiento;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
