using Business.Entities;
using Business.Logic;
using System;

namespace Academia.UI.WindowsForms
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private IUsuarioLogic Logic { get; set; }

        public Usuario UsuarioActual { get; set; }

        public UsuarioDesktop(ModoForm modo, IUsuarioLogic logic) : base(modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.Logic = logic;
        }

        public UsuarioDesktop(int usuarioID, ModoForm modo, IUsuarioLogic logic) : this(modo, logic)
        {
            this.UsuarioActual = this.Logic.GetByID(usuarioID);

            this.MapearDeDatos();
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
        }

        protected override void MapearADatos()
        {
            if (this.UsuarioActual == null)
                this.UsuarioActual = new Usuario();

            this.SetearEstadoEntidad(this.UsuarioActual);

            this.UsuarioActual.ID = int.Parse(this.txtID.Text);
            this.UsuarioActual.Nombre = this.txtNombre.Text;
            this.UsuarioActual.Apellido = this.txtApellido.Text;
            this.UsuarioActual.Email = this.txtEmail.Text;
            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            this.UsuarioActual.Clave = this.txtClave.Text;
            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
        }

        protected override void GuardarCambios()
        {
            this.MapearADatos();

            this.Logic.GuardarCambios(this.UsuarioActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposRequeridos.Add(this.txtUsuario);
            this.CamposRequeridos.Add(this.txtClave);
            this.CamposRequeridos.Add(this.txtNombre);
            this.CamposRequeridos.Add(this.txtApellido);

            if (this.Validar())
            {
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
