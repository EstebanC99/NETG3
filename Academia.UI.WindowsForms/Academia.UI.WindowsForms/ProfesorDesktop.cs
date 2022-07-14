using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class ProfesorDesktop : ApplicationForm<IProfesorUIService, ProfesorVM>
    {
        public ProfesorDesktop()
        {

        }
        public ProfesorDesktop(IProfesorUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);
        }

        public ProfesorDesktop(int profesorID, IProfesorUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(profesorID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposRequeridos.Add(this.txtNombre);
            this.CamposRequeridos.Add(this.txtApellido);
            this.CamposNumericosRequeridos.Add(this.txtLegajo);

            if (this.Validar())
            {
                this.GuardarCambios();

                this.Close();
            }
        }

        protected override void MapearADatos()
        {
            this.Model.ID = int.Parse(this.txtID.Text);
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
