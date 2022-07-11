using Business.Entities;
using Business.Logic;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class ApplicationForm : Form
    {
        protected List<Control> CamposRequeridos { get; set; }

        protected List<Control> CamposNumericosRequeridos { get; set; }

        public ApplicationForm()
        {
            InitializeComponent();

            this.CamposRequeridos = new List<Control>();

            this.CamposNumericosRequeridos = new List<Control>();
        }

        public ApplicationForm(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        public ModoForm Modo { get; set; }

        protected virtual void MapearDeDatos() { }

        protected virtual void MapearADatos() { }

        protected virtual void GuardarCambios() { }

        protected virtual bool Validar() 
        {
            bool valido = true;

            foreach (var control in this.CamposRequeridos)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    control.BackColor = Color.Salmon;
                    valido = false;
                }
                else
                {
                    control.BackColor = Color.Empty;
                }
            }

            foreach (var control in this.CamposNumericosRequeridos)
            {
                int n;

                if (!int.TryParse(control.Text, out n) || string.IsNullOrEmpty(control.Text))
                {
                    control.BackColor = Color.Salmon;
                    valido = false;
                }
                else
                {
                    control.BackColor = Color.Empty;
                }
            }

            return valido; 
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        protected virtual void SetearBoton(Button btn)
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    btn.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    btn.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btn.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btn.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        protected void SetearEstadoEntidad(BusinessEntity entity)
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    entity.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    entity.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    entity.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    entity.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }
    }
}
