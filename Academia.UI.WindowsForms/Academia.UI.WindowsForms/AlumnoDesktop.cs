using Business.Entities;
using Business.Logic.Interfaces;
using System;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class AlumnoDesktop : ApplicationForm
    {
        private IAlumnoLogic Logic { get; set; }

        public Alumno AlumnoActual { get; set; }

        public AlumnoDesktop(ModoForm modo, IAlumnoLogic logic) : base(modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.Logic = logic;
        }

        public AlumnoDesktop(int alumnoID, ModoForm modo, IAlumnoLogic logic) : this(modo, logic)
        {
            this.AlumnoActual = this.Logic.GetByID(alumnoID);

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

        protected override void GuardarCambios()
        {
            this.MapearADatos();

            this.Logic.GuardarCambios(this.AlumnoActual);
        }

        protected override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                this.AlumnoActual = new Alumno();
            }
            else
            {
                this.AlumnoActual = this.Logic.GetByID(int.Parse(this.txtID.Text));
            }

            this.SetearEstadoEntidad(this.AlumnoActual);

            if (int.TryParse(this.txtID.Text, out var r))
                this.AlumnoActual.ID = r;
            this.AlumnoActual.Nombre = this.txtNombre.Text;
            this.AlumnoActual.Apellido = this.txtApellido.Text;
            this.AlumnoActual.Email = this.txtEmail.Text;
            this.AlumnoActual.Direccion = this.txtDireccion.Text;
            this.AlumnoActual.Telefono = this.txtTelefono.Text;
            this.AlumnoActual.Legajo = int.Parse(this.txtLegajo.Text);
            this.AlumnoActual.FechaNacimiento = this.dtFechaNacimiento.Value.Date;
        }
        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.AlumnoActual.ID.ToString();
            this.txtNombre.Text = this.AlumnoActual.Nombre;
            this.txtApellido.Text = this.AlumnoActual.Apellido;
            this.txtEmail.Text = this.AlumnoActual.Email;
            this.txtLegajo.Text = this.AlumnoActual.Legajo.ToString();
            this.txtDireccion.Text = this.AlumnoActual.Direccion;
            this.txtTelefono.Text = this.AlumnoActual.Telefono;
            this.dtFechaNacimiento.Value = this.AlumnoActual.FechaNacimiento;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
