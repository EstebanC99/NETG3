using Academia.UI.Globals;
using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using System.Windows.Forms;
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

            var roles = this.UIService.LeerRoles();

            this.comboRoles.DisplayMember = nameof(this.Model.Descripcion);
            this.comboRoles.ValueMember = nameof(this.Model.ID);

            foreach (var rol in roles)
            {
                this.comboRoles.Items.Add(rol);
            }
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
            this.comboRoles.SelectedIndex = this.comboRoles.FindStringExact(this.Model.RolUsuarioDescripcion);
        }

        protected override void MapearADatos()
        {
            this.Model.Nombre = this.txtNombre.Text;
            this.Model.Apellido = this.txtApellido.Text;
            this.Model.Email = this.txtEmail.Text;
            this.Model.NombreUsuario = this.txtUsuario.Text;
            this.Model.Clave = this.txtClave.Text;
            this.Model.Habilitado = this.chkHabilitado.Checked;
            this.Model.RolUsuarioID = ((ViewModel)this.comboRoles.SelectedItem).ID;
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var personasList = new PersonasList())
            {
                personasList.ShowDialog(this);
            }
        }

        public void RecuperarPersonaElegida(PersonaVM persona)
        {
            if (persona == null)
                return;

            this.Model.PersonaID = persona.ID;
            this.Model.Nombre = persona.Nombre;
            this.Model.Apellido = persona.Apellido;
            this.Model.Email = persona.Email;
            this.txtNombre.Text = this.Model.Nombre;
            this.txtApellido.Text = this.Model.Apellido;
            this.txtEmail.Text = this.Model.Email;

            if (persona.TipoPersonaID == TiposPersona.Administrador)
            {
                this.comboRoles.SelectedIndex = this.comboRoles.FindStringExact(nameof(TiposPersona.Administrador));
                this.comboRoles.Enabled = false;
            } else
            {
                this.comboRoles.Enabled = true;
            }


        }

        protected override bool Validar()
        {
            return base.Validar() && this.ValidarClaves() && this.Model.PersonaID != default(int);
        }

        private bool ValidarClaves()
        {
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                return false;
            }

            if (this.txtClave.Text != this.txtConfirmarClave.Text)
            {
                this.EmitError("Las claves no coinciden");
                return false;
            }

            return true;
        }

        private void btnVerClave_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtClave.PasswordChar = '\0';
        }

        private void btnVerClave_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtClave.PasswordChar = '*';
        }

        private void btnVerConfirmarClave_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtConfirmarClave.PasswordChar = '\0';
        }

        private void btnVerConfirmarClave_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtConfirmarClave.PasswordChar = '*';
        }

        private void txtConfirmarClave_Leave(object sender, EventArgs e)
        {
            this.ValidarClaves();
        }

    }
}
