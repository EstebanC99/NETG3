using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class UsuarioDesktop : ApplicationForm<IUsuarioUIService, UsuarioVM>
    {
        public UsuarioDesktop()
        {

        }
        public UsuarioDesktop(IUsuarioUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);
        }

        public UsuarioDesktop(int usuarioID, IUsuarioUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(usuarioID);

            this.MapearDeDatos();
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.Model.ID.ToString();
            this.txtNombre.Text = this.Model.Nombre;
            this.txtApellido.Text = this.Model.Apellido;
            this.txtEmail.Text = this.Model.Email;
            this.txtUsuario.Text = this.Model.NombreUsuario;
            this.txtClave.Text = this.Model.Clave;
            this.chkHabilitado.Checked = this.Model.Habilitado;
        }

        protected override void MapearADatos()
        {
            this.Model.Nombre = this.txtNombre.Text;
            this.Model.Apellido = this.txtApellido.Text;
            this.Model.Email = this.txtEmail.Text;
            this.Model.NombreUsuario = this.txtUsuario.Text;
            this.Model.Clave = this.txtClave.Text;
            this.Model.Habilitado = this.chkHabilitado.Checked;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposRequeridos.Add(this.txtUsuario);
            this.CamposRequeridos.Add(this.txtClave);
            this.CamposRequeridos.Add(this.txtNombre);
            this.CamposRequeridos.Add(this.txtApellido);

            if (this.Validar())
            {
                this.MapearADatos();

                this.GuardarCambios();

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
