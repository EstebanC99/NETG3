using Academia.UI.Services.Cursos;
using Academia.UI.ViewModels;
using Business.Utils;
using Cross.Exceptions;
using System;
using System.Web.UI;

namespace Academia.UI.WebForm.Areas.Profesores
{
    public partial class IngresoDeNotaForm : System.Web.UI.Page
    {
        private IIngresarNotaUIService IngresarNotaUIService { get; set; }

        private InscripcionVM Inscripcion { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.IngresarNotaUIService = IoCContainer.Instance.TryResolve<IIngresarNotaUIService>();

            if (!Page.IsPostBack)
            {
                this.LeerInscripcion();
                this.CursoDescripcion.Text = $"{this.Inscripcion.MateriaDescripcion}, {this.Inscripcion.AnioCalendario}";
                this.AlumnoInfo.Text = $"{this.Inscripcion.AlumnoApellido}, {this.Inscripcion.AlumnoNombre} - Leg: {this.Inscripcion.AlumnoLegajo}";
                this.txtNota.Text = this.Inscripcion.Nota.ToString();
            }
            if (Page.IsPostBack)
            {
                this.LeerInscripcion();
                this.CargarNota();
            }
        }

        private void LeerInscripcion()
        {
            this.Inscripcion = this.IngresarNotaUIService.LeerInscripcionPorID(int.Parse(Request.QueryString["inscripcionID"]));
        }

        private void CargarNota()
        {
            if (int.TryParse(this.txtNota.Text, out var nota))
            {
                this.Inscripcion.Nota = nota;

                string response;

                try
                {
                    this.IngresarNotaUIService.IngresarNota(this.Inscripcion);
                }
                catch (ValidationException ex)
                {
                    response = string.Format("<script>alert('{0}')</script>", ex.Message);
                    Response.Write(response);
                    return;
                }
                catch (Exception)
                {
                    response = "<script>alert('Se produjo un error, intente nuevamente!')</script>";
                    Response.Write(response);
                    return;
                }

                this.Volver();
            }
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            this.Volver();
        }

        protected void Volver()
        {
            Response.Redirect($"ProfesorListaAlumnos.aspx?cursoID={this.Inscripcion.CursoID}");
        }
    }
}