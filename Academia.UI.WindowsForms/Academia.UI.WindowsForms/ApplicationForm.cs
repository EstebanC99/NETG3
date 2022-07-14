using Academia.UI.Services;
using Academia.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Academia.UI.WindowsForms.ModosForm;

namespace Academia.UI.WindowsForms
{
    public partial class ApplicationForm<TUIService, TViewModel> : Form, IApplicationForm
        where TUIService : IUIService<TViewModel>
        where TViewModel : ViewModel
    {
        protected TUIService UIService { get; set; }

        protected TViewModel Model { get; set; }

        protected List<Control> CamposRequeridos { get; set; }

        protected List<Control> CamposNumericosRequeridos { get; set; }

        public ApplicationForm()
        {

        }

        public ApplicationForm(TUIService uiService) : base()
        {
            this.UIService = uiService;

            this.CamposRequeridos = new List<Control>();

            this.CamposNumericosRequeridos = new List<Control>();

            this.Model = (TViewModel)Activator.CreateInstance(typeof(TViewModel));
        }

        public ApplicationForm(TUIService uiService, ModoForm modo) : this(uiService)
        {
            this.Modo = modo;
        }

        public ModoForm Modo { get; set; }

        protected virtual void MapearDeDatos() { throw new NotImplementedException(); }

        protected virtual void MapearADatos() { throw new NotImplementedException(); }

        protected virtual void GuardarCambios()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.UIService.Registrar(this.Model);
                    break;
                case ModoForm.Modificacion:
                    this.UIService.Modificar(this.Model);
                    break;
                case ModoForm.Baja:
                    this.UIService.Eliminar(this.Model);
                    break;
                default:
                    break;
            }
        }

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
    }
}
