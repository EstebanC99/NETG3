using Business.Entities;
using Business.Logic.Interfaces;
using System;

namespace Academia.UI.WindowsForms
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private IEspecialidadLogic Logic { get; set; }

        private Especialidad EspecialidadActual { get; set; }

        public EspecialidadDesktop(ModoForm modo, IEspecialidadLogic logic) : base(modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.Logic = logic;
        }

        public EspecialidadDesktop(int especialidadID, ModoForm modo, IEspecialidadLogic logic) : this(modo, logic)
        {
            this.EspecialidadActual = this.Logic.GetByID(especialidadID);

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

            this.Logic.GuardarCambios(this.EspecialidadActual);
        }

        protected override bool Validar()
        {
            return true;
        }

        protected override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                this.EspecialidadActual = new Especialidad();
            }
            else
            {
                this.EspecialidadActual = this.Logic.GetByID(int.Parse(this.txtID.Text));
            }

            this.SetearEstadoEntidad(this.EspecialidadActual);

            if (int.TryParse(this.txtID.Text, out var r))
                this.EspecialidadActual.ID = r;
            this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
        }
        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

