using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class CursosDesktop : ApplicationForm<ICursoUIService, CursoVM>
    {
        public CursosDesktop()
        {
        }

        public CursosDesktop(ICursoUIService uiService, ModoForm modo) : base(uiService, modo)
        {
            InitializeComponent();

            this.SetearBoton(this.btnAceptar);

            this.comboComisiones.Items.Clear();
            this.comboComisiones.DisplayMember = nameof(this.Model.Descripcion);
            this.comboComisiones.ValueMember = nameof(this.Model.ID);

            foreach (var item in this.UIService.LeerComisiones())
            {
                this.comboComisiones.Items.Add(item);
            }

            this.comboComisiones.SelectedItem = this.comboComisiones.Items[0];

            this.comboMaterias.Items.Clear();
            this.comboMaterias.DisplayMember = nameof(this.Model.Descripcion);
            this.comboMaterias.ValueMember = nameof(this.Model.ID);

            foreach (var item in this.UIService.LeerMaterias())
            {
                this.comboMaterias.Items.Add(item);
            }

            this.comboMaterias.SelectedItem = this.comboMaterias.Items[0];

            this.txtAnioCalendario.Text = DateTime.Today.Year.ToString();
        }

        public CursosDesktop(int cursoID, ICursoUIService uiService, ModoForm modo) : this(uiService, modo)
        {
            this.Model = this.UIService.LeerPorID(cursoID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CamposNumericosRequeridos.Add(this.txtAnioCalendario);
            this.CamposNumericosRequeridos.Add(this.txtCupo);

            if (this.Validar())
            {
                this.MapearADatos();

                this.GuardarCambios();

                this.Close();
            }
        }

        protected override void MapearADatos()
        {
            this.Model.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
            this.Model.Cupo = int.Parse(this.txtCupo.Text);
            this.Model.MateriaID = ((MateriaVM)this.comboMaterias.SelectedItem).ID;
            this.Model.ComisionID = ((ComisionVM)this.comboComisiones.SelectedItem).ID;
        }

        protected override void MapearDeDatos()
        {
            this.txtID.Text = this.Model.ID.ToString();
            this.txtCupo.Text = this.Model.Cupo.ToString();
            this.txtAnioCalendario.Text = this.Model.AnioCalendario.ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMas_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txtAnioCalendario.Text) < DateTime.Today.AddYears(5).Year)
                this.txtAnioCalendario.Text = (int.Parse(this.txtAnioCalendario.Text) + 1).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txtAnioCalendario.Text) > DateTime.Today.Year)
                this.txtAnioCalendario.Text = (int.Parse(this.txtAnioCalendario.Text) - 1).ToString();
        }
    }
}

