using Academia.UI.Services.Academicos.InscripcionCurso;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.WebForm.Areas.Profesores
{
    public partial class ProfesorListaAlumnos : System.Web.UI.Page
    {
        private IInscripcionCursoUIService InscripcionCursoUIService { get; set; }

        private CursoVM CursoElegido { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.InscripcionCursoUIService = IoCContainer.Instance.TryResolve<IInscripcionCursoUIService>();

            this.CursoElegido = this.InscripcionCursoUIService.LeerCursoPorID(int.Parse(Request.QueryString["cursoID"]));

            if (!Page.IsPostBack)
            {
                this.LeerAlumnosInscriptos();
            }
        }

        private void LeerAlumnosInscriptos()
        {
            this.RepeaterInscriptos.DataSource = this.InscripcionCursoUIService.LeerAlumnosInscriptos(this.CursoElegido.ID);
            this.RepeaterInscriptos.DataBind();
        }

        protected void CargarNota_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect($"IngresoDeNotaForm.aspx?inscripcionID={e.CommandArgument}");
        }

        protected void ModificarNota_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect($"IngresoDeNotaForm.aspx?inscripcionID={e.CommandArgument}");
        }
    }
}