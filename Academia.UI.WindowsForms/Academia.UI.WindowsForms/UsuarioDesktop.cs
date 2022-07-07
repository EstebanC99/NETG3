using Business.Entities;
using Business.Logic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private IUsuarioLogic Logic { get; set; }

        public UsuarioDesktop(IUsuarioLogic logic)
        {
            this.Logic = logic;
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo, IUsuarioLogic logic) : this(logic)
        {
            this.Modo = modo;

            this.SetearBoton();
        }

        public UsuarioDesktop(int usuarioID, ModoForm modo, IUsuarioLogic logic) : this(logic)
        {
            this.Modo = modo;

            this.SetearBoton();

            this.UsuarioActual = this.Logic.GetByID(usuarioID);

            this.MapearDeDatos();
        }

        public Usuario UsuarioActual { get; set; }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
        }

        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.UsuarioActual = new Usuario();
                    this.UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Unmodified;
                    break;
                case ModoForm.Baja:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
                default:
                    break;
            }

            this.UsuarioActual.Nombre = this.txtNombre.Text;
            this.UsuarioActual.Apellido = this.txtApellido.Text;
            this.UsuarioActual.Email = this.txtEmail.Text;
            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            this.UsuarioActual.Clave = this.txtClave.Text;
            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();

            this.Logic.AgregarUsuario(this.UsuarioActual);
        }

        public override bool Validar()
        {
            var esValido = true;

            return esValido;

        }

        private void SetearBoton()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
