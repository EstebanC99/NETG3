using Business.Entities;
using Business.Logic.Interfaces;
using System;

namespace Academia.UI.WindowsForms
{
    public partial class ProfesorDesktop : ApplicationForm
    {
        private IProfesorLogic Logic { get; set; }

        public Profesor ProfesorActual { get; set; }

        public ProfesorDesktop(ModoForm modo, IProfesorLogic logic) : base(modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.Logic = logic;
        }

        public ProfesorDesktop(int usuarioID, ModoForm modo, IProfesorLogic logic) : this(modo, logic)
        {
            this.ProfesorActual = this.Logic.GetByID(usuarioID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();

                this.Close();
            }
        }

        protected override void GuardarCambios()
        {
            this.MapearADatos();

            this.Logic.GuardarCambios(this.ProfesorActual);
        }

        protected override bool Validar()
        {
            return true;
        }

        protected override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                this.ProfesorActual = new Profesor();
            }
            else
            {
                this.ProfesorActual = this.Logic.GetByID(int.Parse(this.txtID.Text));
            }

            this.SetearEstadoEntidad(this.ProfesorActual);

            if (int.TryParse(this.txtID.Text, out var r))
                this.ProfesorActual.ID = r;
            this.ProfesorActual.Nombre = this.txtNombre.Text;
            this.ProfesorActual.Apellido = this.txtApellido.Text;
            this.ProfesorActual.Email = this.txtEmail.Text;
            this.ProfesorActual.Direccion = this.txtDireccion.Text;
            this.ProfesorActual.Telefono = this.txtTelefono.Text;
            this.ProfesorActual.Legajo = int.Parse(this.txtLegajo.Text);
            this.ProfesorActual.FechaNacimiento = this.dtFechaNacimiento.Value.Date;
        }
        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.ProfesorActual.ID.ToString();
            this.txtNombre.Text = this.ProfesorActual.Nombre;
            this.txtApellido.Text = this.ProfesorActual.Apellido;
            this.txtEmail.Text = this.ProfesorActual.Email;
            this.txtLegajo.Text = this.ProfesorActual.Legajo.ToString();
            this.txtDireccion.Text = this.ProfesorActual.Direccion;
            this.txtTelefono.Text = this.ProfesorActual.Telefono;
            this.dtFechaNacimiento.Value = this.ProfesorActual.FechaNacimiento;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
